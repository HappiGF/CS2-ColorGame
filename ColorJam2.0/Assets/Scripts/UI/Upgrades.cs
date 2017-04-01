using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour {

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
        s1 = true;
        s2 = true;
        s3 = true;
        s4 = true;
        s5 = true;

        redC = GameObject.Find("Canvas").GetComponent<UIManager>().redC;
        blueC = GameObject.Find("Canvas").GetComponent<UIManager>().blueC;
        yellowC = GameObject.Find("Canvas").GetComponent<UIManager>().yellowC;


        if ((redC < 200 || blueC < 150 || yellowC < 50) || s5Bought == true || s4Bought == false || s3Bought == false || s2Bought == false || s1Bought == false)
        {
            s5 = false;
        }
        if ((redC < 150 || blueC < 100) || s4Bought == true || s3Bought == false || s2Bought == false || s1Bought == false)
        {
            s4 = false;
        }
        if ((redC < 100 || blueC < 50) || s3Bought == true || s2Bought == false || s1Bought == false)
        {
            s3 = false;
        }
        if (redC < 50 || s2Bought == true || s1Bought == true)
        {
            s2 = false;
        }
        if (redC < 10 || s1Bought == true)
        {
            s1 = false;
        }

        speed1.gameObject.SetActive(s1);
        speed2.gameObject.SetActive(s2);
        speed3.gameObject.SetActive(s3);
        speed4.gameObject.SetActive(s4);
        speed5.gameObject.SetActive(s5);
    }
}
