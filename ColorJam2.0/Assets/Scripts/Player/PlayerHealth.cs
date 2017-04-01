using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public float maxHealth;
    public float currentHealth;
	Canvas canvas;

	void Start () {
        currentHealth = maxHealth;
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
	}

    public void UpdateHealth()
    {
        currentHealth = maxHealth;
        canvas.GetComponent<UIManager>().UpdateHealth(currentHealth);
    }
	
	public void PlayerHit(float damg) {
        currentHealth -= damg;
		canvas.GetComponent<UIManager> ().UpdateHealth (currentHealth);
		if (currentHealth <= 0) {
			SceneManager.LoadScene ("GameOver");
		}
    }
}
