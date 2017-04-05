using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUpgrade : MonoBehaviour {

    float redCost;
    float blueCost;
    float yellowCost;
    float multiplier;

    public void Bought()
    {
        if (name == "Health1")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().h1Bought = true;
            redCost = 0;
            blueCost = 10;
            yellowCost = 10;
            multiplier = 1;
        }
        else if (name == "Health2")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().h2Bought = true;
            redCost = 0;
            blueCost = 20;
            yellowCost = 20;
            multiplier = 2;
        }
        else if (name == "Health3")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().h3Bought = true;
            redCost = 0;
            blueCost = 50;
            yellowCost = 50;
            multiplier = 3;
        }
        else if (name == "Health4")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().h4Bought = true;
            redCost = 0;
            blueCost = 150;
            yellowCost = 150;
            multiplier = 4;
        }
        else if (name == "Health5")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().h5Bought = true;
            redCost = 10;
            blueCost = 200;
            yellowCost = 200;
            multiplier = 5;
        }
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractRedC(redCost);
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractBlueC(blueCost);
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractYellowC(yellowCost);

        GameObject.Find("Player").GetComponent<PlayerHealth>().maxHealth += 10 * multiplier;
    }
}
