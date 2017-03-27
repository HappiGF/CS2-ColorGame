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
	public GameObject completed;
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
            yield return new WaitForSeconds(.6f);
            flashingText.text = "Ready [x]";
            yield return new WaitForSeconds(.6f);
        }
    }

    public void ReadyOff()
    {
        flashingText.text = "";
    }

	public void CompletedLevelAnim(bool show)
	{
		completed.SetActive (show);
	}
}
