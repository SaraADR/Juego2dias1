using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject shot;
    public float cooldown;
    private float nextShot;

	// Update is called once per frame
	void Update () {

        if (((Input.GetKey(KeyCode.Space)))&&(Time.time > nextShot))
        {
            Instantiate(shot, transform.position, Quaternion.identity);
            nextShot = Time.time + cooldown;
        }

	}
}
