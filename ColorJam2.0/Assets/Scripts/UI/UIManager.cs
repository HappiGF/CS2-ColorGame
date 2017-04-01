using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public Text healthText;
    public Text scoreText;
    public Text flashingText;
    public Text waveName;

    public GameObject master;
	public GameObject completed;

    float score;

	public Text redCText;
	public float redC;

	public Text blueCText;
	public float blueC;

	public Text yellowCText;
	public float yellowC;

    void Start(){
        score = 0;
		redC = 0;
		blueC = 0;
		yellowC = 0;
        UpdateScore(score);
        waveName.text = "";
        flashingText.text = "";
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

    public void subtractRedC(float amount)
    {
        redC -= amount;
        redCText.text = "" + redC;
    }

    public void updateBlueC()
	{
		int amount = Random.Range (5, 21);
		blueC += amount;
		blueCText.text = "" + blueC;
	}

    public void subtractBlueC(float amount)
    {
        blueC -= amount;
        blueCText.text = "" + blueC;
    }

    public void updatetYellowC()
	{
		int amount = Random.Range (10, 21);
		yellowC += amount;
		yellowCText.text = "" + yellowC;
	}

    public void subtractYellowC(float amount)
    {
        yellowC -= amount;
        yellowCText.text = "" + yellowC;
    }
}
