using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageUpgrade : MonoBehaviour {

    float redCost;
    float blueCost;
    float yellowCost;

    public void Bought()
    {
        if (name == "Damage1")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().d1Bought = true;
            redCost = 0;
            blueCost = 0;
            yellowCost = 10;
        }
        else if (name == "Damage2")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().d2Bought = true;
            redCost = 0;
            blueCost = 0;
            yellowCost = 50;
        }
        else if (name == "Damage3")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().d3Bought = true;
            redCost = 50;
            blueCost = 0;
            yellowCost = 100;
        }
        else if (name == "Damage4")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().d4Bought = true;
            redCost = 100;
            blueCost = 0;
            yellowCost = 150;
        }
        else if (name == "Damage5")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().d5Bought = true;
            redCost = 150;
            blueCost = 50;
            yellowCost = 200;
        }
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractRedC(redCost);
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractBlueC(blueCost);
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractYellowC(yellowCost);

        GameObject.Find("Player").GetComponent<ProjectileJam>().damage += 5;
    }
}
