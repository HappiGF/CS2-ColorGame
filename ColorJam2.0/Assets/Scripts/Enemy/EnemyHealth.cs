using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int maxHealth;
    public float currentHealth;
    Canvas canvas;

	void Start () {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
		Spawn();
    }

	public void WasHit(float damg, int score, string enemy) {
        currentHealth -= damg;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
			if (enemy == "r") {
				canvas.GetComponent<UIManager> ().updateRedC ();
			} else if (enemy == "b") {;
				canvas.GetComponent<UIManager> ().updateBlueC ();
			} else if (enemy == "y"){
				canvas.GetComponent<UIManager> ().updatetYellowC ();
			}
            canvas.GetComponent<UIManager>().UpdateScore(score);
        } 
    }

	void Spawn() {
		int waveNum = GameObject.Find ("Master").GetComponent<WaveSpawner> ().getWaveNumber ();
		if (name == "EnemyBlue(Clone)") {
			maxHealth = (int)(40 + waveNum * 0.4);
		} else if (name == "EnemyRed(Clone)") {
			maxHealth = (int)(20 + waveNum * 0.4);
		} else if (name == "EnemyYellow(Clone)") {
			maxHealth = (int)(100 + waveNum * 0.4);
		}
		currentHealth = maxHealth;
	}
}
