using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackRateUpgrade : MonoBehaviour {

    float redCost;
    float blueCost;
    float yellowCost;

    public void Bought()
    {
        if (name == "ARate1")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().ar1Bought = true;
            redCost = 0;
            blueCost = 50;
            yellowCost = 0;
        }
        else if (name == "ARate2")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().ar2Bought = true;
            redCost = 0;
            blueCost = 100;
            yellowCost = 0;
        }
        else if (name == "ARate3")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().ar3Bought = true;
            redCost = 0;
            blueCost = 200;
            yellowCost = 50;
        }
        else if (name == "ARate4")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().ar4Bought = true;
            redCost = 0;
            blueCost = 400;
            yellowCost = 100;
        }
        else if (name == "ARate5")
        {
            GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().ar5Bought = true;
            redCost = 50;
            blueCost = 500;
            yellowCost = 200;
        }
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractRedC(redCost);
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractBlueC(blueCost);
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractYellowC(yellowCost);

        GameObject.Find("Player").GetComponent<ProjectileJam>().repeatRate -= (float)0.082;
    }
}
