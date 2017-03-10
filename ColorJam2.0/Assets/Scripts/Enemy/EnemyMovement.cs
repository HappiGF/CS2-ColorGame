using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public GameObject Player;
    public float Speed;
    public float minDist;
	public float attackRate;

	void Start()
	{
		InvokeRepeating("AttackPlayer", 0.0f, attackRate);
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
			Debug.Log ("player was hit");
			Player.GetComponent<PlayerHealth> ().PlayerHit (10);
		}
	}
}
