using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float maxHealth;
    float currentHealth;

	void Start () {
        currentHealth = maxHealth;	
	}
	
	public void PlayerHit(float damg)
    {
        currentHealth -= damg;
        Debug.Log(currentHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
