using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public float maxHealth;
    public float currentHealth;
	public Text text;

	void Start () {
        currentHealth = maxHealth;	
	}
	
	public void PlayerHit(float damg) {
        currentHealth -= damg;
		text.GetComponent<UIManager> ().UpdateHealth (currentHealth);
		if (currentHealth <= 0) {
			SceneManager.LoadScene ("GameOver");
		}
    }
}
