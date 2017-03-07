using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public GameObject Player;
    public float Speed;
    public float minDist;

    void Update()
    {
        transform.LookAt(Player.transform);

        if (Vector3.Distance(transform.position, Player.transform.position) >= minDist)
        {

            transform.position += transform.forward * Speed * Time.deltaTime;
        }
    }
}
