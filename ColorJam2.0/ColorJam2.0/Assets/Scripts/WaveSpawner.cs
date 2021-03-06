﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

	public enum SpawnState { SPAWING, WAITING, COUNTING };

	[System.Serializable]
	public class Wave {
			public string name;
			public Transform[] enemies;
			public int count;
			public float rate;
	}

	public Wave[] waves;
	private int nextWave = 0;

	public Transform[] spawnPoints;

	public float timeBetweenWaves = 5f;
	public float waveCountdown;

	private float searchCountdown = 1f;

	public SpawnState state = SpawnState.COUNTING;

	void Start() {
		if (spawnPoints.Length == 0) {
			Debug.LogError ("No spawn points referenced.");
		}

		waveCountdown = timeBetweenWaves;
	}

	void Update () {
		if (state == SpawnState.WAITING) {
			if (!EnemyIsAlive ()) {
				WaveCompleted ();
			} else {
				return;
			}
		}
		if (waveCountdown <= 0) {
			if (state != SpawnState.SPAWING) {
				StartCoroutine (SpawnWave (waves [nextWave]));
			}
		} else {
			waveCountdown -= Time.deltaTime;
		}
	}

	void WaveCompleted() {
		Debug.Log ("Wave Completed");

		state = SpawnState.COUNTING;
		waveCountdown = timeBetweenWaves;

		if (nextWave + 1 > waves.Length - 1) {
			nextWave = 0;
			Debug.Log ("ALL WAVES COMPLETE! Looping...");
		} else {
			nextWave++;
		}
	}

	bool EnemyIsAlive(){
		searchCountdown -= Time.deltaTime;
		if (searchCountdown <= 0f) {
			searchCountdown = 1f;
			if (GameObject.FindGameObjectsWithTag ("Enemy").Length == 0) {
				return false;
			}
		}
		return true;
	}

	IEnumerator SpawnWave(Wave _wave) {
		Debug.Log ("Spawning Wave: " + _wave.count);
		state = SpawnState.SPAWING;

		for (int i = 0; i < _wave.count; i++) {
			SpawnEnemy (_wave.enemies);
			yield return new WaitForSeconds (1f / _wave.rate);
		}

		state = SpawnState.WAITING;

		yield break;
	}

	void SpawnEnemy (Transform[] _enemies) {
		Transform _enemy;
		if (_enemies.Length > 1) {
			int ran = Random.Range (0, 10);
			if (ran < 2) {
				_enemy = _enemies[3]
			}
		} else {
			_enemy = _enemies[0];
		}
		Transform _enemy = _enemies [Random.Range (0, _enemies.Length)];
		Transform _sp = spawnPoints [Random.Range (0, spawnPoints.Length)];
		Instantiate (_enemy, _sp.position, _sp.rotation);
	}
}
