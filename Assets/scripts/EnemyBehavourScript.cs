using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavourScript : MonoBehaviour {

    public float limit;
    private bool left;
    private bool down;
    public float speedMovement = 1.0f;
    private float num = 0;
    // Use this for initialization
    void Start () {
        left = false;
        down = false;
    }
	
	// Update is called once per frame
	void Update () {
        num += Time.deltaTime;
        if (num > 1.0)
        {
            LeftMovement();
            //Hacer un delay para que cuando baje de la izquierda no se invoque a la derecha
            RightMovement();
            num = 0;
        }
	}

    private void LeftMovement()
    {
        if (left && transform.position.x > -limit + transform.localScale.x / 2)
        {
            transform.position = new Vector3(transform.position.x - 0.9f, transform.position.y, transform.position.z);
        }
        else
        {
            left = false;
            if (down) {
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.9f, transform.position.z);
                down = false;
            }
        }
    }

    private void RightMovement()
    {
        if (!left && transform.position.x < limit - transform.localScale.x / 2)
        {
            transform.position = new Vector3(transform.position.x + 0.9f, transform.position.y, transform.position.z);
        }
        else
        {
            left = true;
            if (!down)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.9f, transform.position.z);
                down = true;
            }
        }
    }
}
