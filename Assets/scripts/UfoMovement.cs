using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoMovement : MonoBehaviour {

    public float limit;
    public float speedMovement = 1.0f;
    private float delay = 0;
	
	// Update is called once per frame
	void Update () {

        delay += Time.deltaTime;
        if (delay > 10.0)
        {
            transform.position = new Vector3(transform.position.x + speedMovement * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= limit - transform.localScale.x)
        {
            resetPosition();
            delay = 0;
        }
    }

    public void resetPosition()
    {
        transform.position = new Vector3(-13.73f, 6.7f, 0);
        delay = 0;
    }
}
