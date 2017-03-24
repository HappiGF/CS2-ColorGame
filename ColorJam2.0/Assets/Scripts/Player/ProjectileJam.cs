using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileJam : MonoBehaviour {

	GameObject prefab;
    GameObject projectilRed;
    GameObject projectileBlue;
    GameObject projectileYellow;
	public float projectileLife;
	public float projectileVelocity;
    public float repeatRate;

	void Start () {
		projectilRed = Resources.Load ("Projectiles/projectileRed") as GameObject;
        projectileBlue = Resources.Load("Projectiles/projectileBlue") as GameObject;
        projectileYellow = Resources.Load("Projectiles/projectileYellow") as GameObject;
        prefab = projectilRed;
        InvokeRepeating("Shoot", 0.0f, repeatRate);
	}

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            prefab = projectilRed;
            Debug.Log("red");
        }
        if (Input.GetKeyDown("2"))
        {
            prefab = projectileBlue;
            Debug.Log("blue");
        }
        if (Input.GetKeyDown("3"))
        {
            prefab = projectileYellow;
            Debug.Log("yellow");
        }
    }

	void Shoot () {
        if (Input.GetMouseButton(0))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + transform.forward * 1.1f;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * projectileVelocity;
            Destroy(projectile, projectileLife);
        }
    }
}
