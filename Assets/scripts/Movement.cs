using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 15f;
    public double limit;


	// Update is called once per frame
	void Update () {


        if ((Input.GetKey(KeyCode.A)) && (transform.position.x > -limit + transform.localScale.x / 2))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) && (transform.position.x < limit - transform.localScale.x / 2))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            gameObject.GetComponent<PlayerLifes>().recieveDamage();
        }
    }
}
