using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public float maxHealth;
    float currentHealth;
    Canvas canvas;

	void Start () {
        currentHealth = maxHealth;
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
    }

	public void WasHit(float damg, int score) {
        currentHealth -= damg;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            canvas.GetComponent<UIManager>().UpdateScore(score);
        } 
    }
}
