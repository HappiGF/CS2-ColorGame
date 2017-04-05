using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public GameObject Player;
    public float Speed;
    public float minDist;
	public float attackRate;
	public int damgPlayer;

	void Start()
	{
		Spawn ();
		InvokeRepeating("AttackPlayer", 0.0f, attackRate);
		Player = GameObject.Find ("Player");
	}

	void Spawn() {
		int waveNum = GameObject.Find ("Master").GetComponent<WaveSpawner> ().getWaveNumber ();
		if (name == "EnemyRed(Clone)") {
			Speed = (float)(9 + waveNum * 0.15);
			damgPlayer = (int)(5 + waveNum * 0.18);
		} else if (name == "EnemyBlue(Clone)") {
			Speed = (float)(7 + waveNum * 0.15);
			damgPlayer = (int)(10 + waveNum * 0.18);
		} else if (name == "EnemyYellow(Clone)") {
			Speed = (float)(5 + waveNum * 0.15);
			damgPlayer = (int)(15 + waveNum * 0.18);
		}
	}

    void Update()
    {
		MoveToPlayer ();
    }

	void MoveToPlayer()
	{
		transform.LookAt(Player.transform);

		if (Vector3.Distance(transform.position, Player.transform.position) >= minDist)
		{

			transform.position += transform.forward * Speed * Time.deltaTime;

		}
	}

	void AttackPlayer()
	{
		if (Vector3.Distance (transform.position, Player.transform.position) < minDist + 0.01f) 
		{
			Player.GetComponent<PlayerHealth> ().PlayerHit (damgPlayer);
		}
	}
}
