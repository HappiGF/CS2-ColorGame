using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public Text healthText;
    public Text scoreText;
    public Text flashingText;
    public GameObject master;
	public GameObject completed;
    public Text waveName;
    float score;
	public Text redCText;
	float redC;
	public Text blueCText;
	float blueC;
	public Text yellowCText;
	float yellowC;

    void Start(){
        score = 0;
		redC = 0;
		blueC = 0;
		yellowC = 0;
        UpdateScore(score);
        flashingText.text = "";
        waveName.text = "";
        CompletedLevelAnim(false, "");
    }
	
	public void UpdateHealth(float amount){
		healthText.text = amount + "/100";
	}

    public void UpdateScore(float amount){
        score += amount;
        scoreText.text = "" + score;
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

	public void CompletedLevelAnim(bool show, string name)
	{
        setWaveName(name);
		completed.SetActive (show);
	}

    void setWaveName(string name)
    {
        waveName.text = name;
    }

	public void updateRedC()
	{
		int amount = Random.Range (1, 16);
		redC += amount;
		redCText.text = "" + redC;

	}

	public void updateBlueC()
	{
		int amount = Random.Range (5, 21);
		blueC += amount;
		blueCText.text = "" + blueC;
	}

	public void updatetYellowC()
	{
		int amount = Random.Range (10, 21);
		yellowC += amount;
		yellowCText.text = "" + yellowC;
	}
}
