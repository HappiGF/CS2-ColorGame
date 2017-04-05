using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpgrade : MonoBehaviour {

    float redCost;
    float blueCost;
    float yellowCost;
    float multiplier;

    public void Bought()
    {
        if (name == "Speed1")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().s1Bought = true;
            redCost = 50;
            blueCost = 0;
            yellowCost = 0;
            multiplier = 1;
        }
        else if (name == "Speed2")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().s2Bought = true;
            redCost = 100;
            blueCost = 0;
            yellowCost = 0;
            multiplier = 2;
        }
        else if (name == "Speed3")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().s3Bought = true;
            redCost = 200;
            blueCost = 50;
            yellowCost = 0;
            multiplier = 3;
        }
        else if (name == "Speed4")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().s4Bought = true;
            redCost = 400;
            blueCost = 100;
            yellowCost = 0;
            multiplier = 4;
        }
        else if (name == "Speed5")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().s5Bought = true;
            redCost = 500;
            blueCost = 200;
            yellowCost = 50;
            multiplier = 5;
        }
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractRedC(redCost);
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractBlueC(blueCost);
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractYellowC(yellowCost);

        GameObject.Find("Player").GetComponent<PlayerMovement>().speed += 1 * multiplier;
    }
}
