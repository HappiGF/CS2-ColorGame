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
			Debug.Log ("update score");
            canvas.GetComponent<UIManager>().UpdateScore(score);
        } 
    }

	public void setMaxHealth(float max){
		maxHealth = max;
		currentHealth = maxHealth;
	}
}
