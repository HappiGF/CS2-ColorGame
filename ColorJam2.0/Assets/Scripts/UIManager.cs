using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public Text healthText;
    public Text scoreText;
    public Text flashingText;
    public Text waveCompleteText;
    public GameObject master;

    float score;

    void Start(){
        score = 0;
        UpdateScore(score);
        flashingText.text = "";
        waveCompleteText.text = "";
    }
	
	public void UpdateHealth(float amount){
		healthText.text = amount + "/100";
	}

    public void UpdateScore(float amount){
        score += amount;
        scoreText.text = "Score: " + score;
    }

    public IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = "";
            yield return new WaitForSeconds(.5f);
            flashingText.text = "Ready [x]";
            yield return new WaitForSeconds(.5f);
        }
    }

    public void ReadyOff()
    {
        flashingText.text = "";
    }

    public void WaveComplete(bool show)
    {
        if (show)
        {
            waveCompleteText.text = "Wave " + master.GetComponent<WaveSpawner>().waveName + " Complete!";
        }
        else
        {
            waveCompleteText.text = "";
        }
    }
}
