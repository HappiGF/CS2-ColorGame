using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour {

    public float damg;

	void OnTriggerEnter (Collider col) { 
		if (col.gameObject.name == "EnemyRed(Clone)" && this.name == "projectileRed(Clone)")
        {
            col.gameObject.GetComponent<EnemyHealth>().WasHit(damg, 10, "r");
        }
		else if (col.gameObject.name == "EnemyBlue(Clone)" && this.name == "projectileBlue(Clone)")
        {
            col.gameObject.GetComponent<EnemyHealth>().WasHit(damg, 20, "b");
        }
		else if (col.gameObject.name == "EnemyYellow(Clone)" && this.name == "projectileYellow(Clone)")
        {
            col.gameObject.GetComponent<EnemyHealth>().WasHit(damg, 50, "y");
        }
        Destroy(gameObject);
    }
}
