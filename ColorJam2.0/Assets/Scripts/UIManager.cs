using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	Text health;
	// Use this for initialization
	void Start () {
		health = GetComponent<Text>();
	}
	
	public void UpdateHealth(float amount){
		health.text = amount + "/100";
	}
}
