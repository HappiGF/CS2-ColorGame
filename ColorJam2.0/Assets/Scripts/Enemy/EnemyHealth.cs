using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public float maxHealth;
    float currentHealth;

	void Start () {
        currentHealth = maxHealth;
	}

    public void WasHit(float damg) {
        currentHealth -= damg;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        } 
    }
}
