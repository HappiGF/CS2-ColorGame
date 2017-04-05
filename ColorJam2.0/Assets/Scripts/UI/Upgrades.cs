using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour {

	public Text CopyScore;
	public Text CopyRedC;
	public Text CopyBlueC;
	public Text CopyYellowC;

	/*======================================================================================*/

    public Button speed1;
    public Button speed2;
    public Button speed3;
    public Button speed4;
    public Button speed5;

    public bool s1;
    public bool s2;
    public bool s3;
    public bool s4;
    public bool s5;

    public bool s1Bought = false;
    public bool s2Bought = false;
    public bool s3Bought = false;
    public bool s4Bought = false;
    public bool s5Bought = false;

    /*======================================================================================*/

    public Button arate1;
    public Button arate2;
    public Button arate3;
    public Button arate4;
    public Button arate5;

    public bool ar1;
    public bool ar2;
    public bool ar3;
    public bool ar4;
    public bool ar5;

    public bool ar1Bought = false;
    public bool ar2Bought = false;
    public bool ar3Bought = false;
    public bool ar4Bought = false;
    public bool ar5Bought = false;

    /*======================================================================================*/

    public Button damage1;
    public Button damage2;
    public Button damage3;
    public Button damage4;
    public Button damage5;

    public bool d1;
    public bool d2;
    public bool d3;
    public bool d4;
    public bool d5;

    public bool d1Bought = false;
    public bool d2Bought = false;
    public bool d3Bought = false;
    public bool d4Bought = false;
    public bool d5Bought = false;

    /*======================================================================================*/

    public Button health1;
    public Button health2;
    public Button health3;
    public Button health4;
    public Button health5;

    public bool h1;
    public bool h2;
    public bool h3;
    public bool h4;
    public bool h5;

    public bool h1Bought = false;
    public bool h2Bought = false;
    public bool h3Bought = false;
    public bool h4Bought = false;
    public bool h5Bought = false;

    float redC;
    float blueC;
    float yellowC;

    void LateUpdate()
    {
		CopyScore.text = "Score: " + GameObject.Find ("Canvas").GetComponent<UIManager> ().getScore();
		CopyRedC.text = GameObject.Find ("Canvas").GetComponent<UIManager> ().getRedC();
		CopyBlueC.text = GameObject.Find ("Canvas").GetComponent<UIManager> ().getBlueC();
		CopyYellowC.text = GameObject.Find ("Canvas").GetComponent<UIManager> ().getYellowC();

        redC = GameObject.Find("Canvas").GetComponent<UIManager>().redC;
        blueC = GameObject.Find("Canvas").GetComponent<UIManager>().blueC;
        yellowC = GameObject.Find("Canvas").GetComponent<UIManager>().yellowC;

        s1 = true;
        s2 = true;
        s3 = true;
        s4 = true;
        s5 = true;

        if ((redC < 500 || blueC < 200 || yellowC < 50) || s5Bought == true || s4Bought == false || s3Bought == false || s2Bought == false || s1Bought == false)
        {
            s5 = false;
        }
        if ((redC < 400 || blueC < 100) || s4Bought == true || s3Bought == false || s2Bought == false || s1Bought == false)
        {
            s4 = false;
        }
        if ((redC < 200 || blueC < 50) || s3Bought == true || s2Bought == false || s1Bought == false)
        {
            s3 = false;
        }
        if (redC < 100 || s2Bought == true || s1Bought == false)
        {
            s2 = false;
        }
        if (redC < 50 || s1Bought == true)
        {
            s1 = false;
        }

        speed1.interactable = s1;
        speed2.interactable = s2;
        speed3.interactable = s3;
        speed4.interactable = s4;
        speed5.interactable = s5;

        /*======================================================================================*/

        ar1 = true;
        ar2 = true;
        ar3 = true;
        ar4 = true;
        ar5 = true;

        if ((blueC < 500 || yellowC < 200 || redC < 50) || ar5Bought == true || ar4Bought == false || ar3Bought == false || ar2Bought == false || ar1Bought == false)
        {
            ar5 = false;
        }
        if ((blueC < 400 || yellowC < 100) || ar4Bought == true || ar3Bought == false || ar2Bought == false || ar1Bought == false)
        {
            ar4 = false;
        }
        if ((blueC < 200 || yellowC < 50) || ar3Bought == true || ar2Bought == false || ar1Bought == false)
        {
            ar3 = false;
        }
        if (blueC < 100 || ar2Bought == true || ar1Bought == false)
        {
            ar2 = false;
        }
        if (blueC < 50 || ar1Bought == true)
        {
            ar1 = false;
        }

        arate1.interactable = ar1;
        arate2.interactable = ar2;
        arate3.interactable = ar3;
        arate4.interactable = ar4;
        arate5.interactable = ar5;

        /*======================================================================================*/

        d1 = true;
        d2 = true;
        d3 = true;
        d4 = true;
        d5 = true;

        if ((yellowC < 500 || redC < 200 || blueC < 50) || d5Bought == true || d4Bought == false || d3Bought == false || d2Bought == false || d1Bought == false)
        {
            d5 = false;
        }
        if ((yellowC < 400 || redC < 100) || d4Bought == true || d3Bought == false || d2Bought == false || d1Bought == false)
        {
            d4 = false;
        }
        if ((yellowC < 200 || redC < 50) || d3Bought == true || d2Bought == false || d1Bought == false)
        {
            d3 = false;
        }
        if (yellowC < 100 || d2Bought == true || d1Bought == false)
        {
            d2 = false;
        }
        if (yellowC < 50 || d1Bought == true)
        {
            d1 = false;
        }

        damage1.interactable = d1;
        damage2.interactable = d2;
        damage3.interactable = d3;
        damage4.interactable = d4;
        damage5.interactable = d5;

        /*======================================================================================*/

        h1 = true;
        h2 = true;
        h3 = true;
        h4 = true;
        h5 = true;

        if ((yellowC < 500 || redC < 50 || blueC < 500) || h5Bought == true || h4Bought == false || h3Bought == false || h2Bought == false || h1Bought == false)
        {
            h5 = false;
        }
        if ((yellowC < 250 || blueC < 250) || h4Bought == true || h3Bought == false || h2Bought == false || h1Bought == false)
        {
            h4 = false;
        }
        if ((yellowC < 150 || blueC < 150) || h3Bought == true || h2Bought == false || h1Bought == false)
        {
            h3 = false;
        }
        if ((yellowC < 100 || blueC < 100) || h2Bought == true || h1Bought == false)
        {
            h2 = false;
        }
        if ((yellowC < 50 || blueC < 50) || h1Bought == true)
        {
            h1 = false;
        }

        health1.interactable = h1;
        health2.interactable = h2;
        health3.interactable = h3;
        health4.interactable = h4;
        health5.interactable = h5;
    }
}
