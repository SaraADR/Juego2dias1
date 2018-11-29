using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllienControllerMovement : MonoBehaviour
{

    bool movingRight = true;
    public float speed = 0.5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            //transform.position += Vector3.right * speed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        else
        {
            //transform.position += Vector3.left * speed * Time.deltaTime;
            transform.position =  new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }

    public void changeMovement()
    {
        movingRight = !movingRight;
    }

    /*void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Boundarie")
        {
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y - 1, 0);
            transform.position = newPos;
            movingRight = !movingRight;
        }
        
    }*/
}