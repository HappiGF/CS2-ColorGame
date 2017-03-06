using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour {

	void OnTriggerEnter (Collider col) { 
		if (col.gameObject.name == "EnemyRed" && this.name == "projectileRed(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        else if (col.gameObject.name == "EnemyBlue" && this.name == "projectileBlue(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        else if (col.gameObject.name == "EnemyYellow" && this.name == "projectileYellow(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
