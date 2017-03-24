using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    public enum SpawnState { SPAWING, WAITING, COUNTING };

    [System.Serializable]
    public class Wave
    {
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

	bool ready;
	bool blinking;

    void Start()
    {
        if (spawnPoints.Length == 0)
        {
            Debug.LogError("No spawn points referenced.");
        }

        waveCountdown = timeBetweenWaves;
		ready = false;
		StartCoroutine (GameObject.Find ("Canvas").GetComponent<UIManager> ().BlinkText ());
    }

    void Update()
    {
        if (state == SpawnState.WAITING)
        {
            if (!EnemyIsAlive())
            {
				WaveCompleted ();
				StartCoroutine (GameObject.Find ("Canvas").GetComponent<UIManager> ().BlinkText ());
            }
            else
            {
                return;
            }
        }
		if (ready) {
			if (waveCountdown <= 0) {
				if (state != SpawnState.SPAWING) {
					StartCoroutine (SpawnWave (waves [nextWave]));
					ready = false;
				}
			}
			else
			{
				waveCountdown -= Time.deltaTime;
			}
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			ready = true; 
			StopCoroutine (GameObject.Find ("Canvas").GetComponent<UIManager> ().BlinkText ());
		}
    }

    void WaveCompleted()
    {
        Debug.Log("Wave Completed");
		state = SpawnState.COUNTING;
		waveCountdown = timeBetweenWaves;

		if (nextWave + 1 > waves.Length - 1)
		{
			nextWave = 0;
			Debug.Log("ALL WAVES COMPLETE! Looping...");
		}
		else
		{
			nextWave++;
		}        
    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {
            searchCountdown = 1f;
            if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            {
                return false;
            }
        }
        return true;
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("Spawning Wave: " + _wave.count);
        state = SpawnState.SPAWING;

        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemies);
            yield return new WaitForSeconds(1f / _wave.rate);
        }

        state = SpawnState.WAITING;

        yield break;
    }

    void SpawnEnemy(Transform[] _enemies)
    {
        Transform _enemy;
        if (_enemies.Length > 1)
        {
            int ran = Random.Range(1, 11);
            if (ran <= 2)
            {
                //yellow
                _enemy = _enemies[2];
            }
            else if (ran >= 8)
            {
                //blue
                _enemy = _enemies[1];
            }
            else
            {
                //red
                _enemy = _enemies[0];
            }
        }
        else
        {
            _enemy = _enemies[0];
        }
        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_enemy, _sp.position, _sp.rotation);
    }
}
