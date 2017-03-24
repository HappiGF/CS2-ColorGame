using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileJam : MonoBehaviour {

	GameObject prefab;
    GameObject prefabRed;
    GameObject prefabBlue;
    GameObject prefabYellow;
	public float projectileLife;
	public float projectileVelocity;
    public float repeatRate;

	void Start () {
		prefabRed = Resources.Load ("Projectiles/projectileRed") as GameObject;
        prefabBlue = Resources.Load("Projectiles/projectileBlue") as GameObject;
        prefabYellow = Resources.Load("Projectiles/projectileYellow") as GameObject;
        prefab = prefabRed;
        InvokeRepeating("Shoot", 0.0f, repeatRate);
	}

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            prefab = prefabRed;
            Debug.Log("red");
        }
        if (Input.GetKeyDown("2"))
        {
            prefab = prefabBlue;
            Debug.Log("blue");
        }
        if (Input.GetKeyDown("3"))
        {
            prefab = prefabYellow;
            Debug.Log("yellow");
        }
    }

	void Shoot () {
        if (Input.GetMouseButton(0))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + transform.forward * 1.5f;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * projectileVelocity;
            Destroy(projectile, projectileLife);
        }
    }
}
