using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed5Button : MonoBehaviour {

    public bool purchased = false;

    public void Bought()
    {
        GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().speed5.gameObject.SetActive(false);
        GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().s5Bought = true;
        purchased = true;
        GameObject.Find("Player").GetComponent<PlayerMovement>().speed += 2;
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractRedC(200);
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractBlueC(150);
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractYellowC(50);
    }
}
