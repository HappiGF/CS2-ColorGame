using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed1Button : MonoBehaviour {

    public bool purchased = false;

    public void Bought()
    {
        GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().speed1.gameObject.SetActive(false);
        GameObject.Find("UpgradeBackPanel").GetComponent<Upgrades>().s1Bought = true;
        purchased = true;
        GameObject.Find("Player").GetComponent<PlayerMovement>().speed += 2;
        GameObject.Find("Canvas").GetComponent<UIManager>().subtractRedC(10);

    }
}
