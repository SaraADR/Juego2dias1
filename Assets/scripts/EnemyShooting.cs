using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

    public GameObject shot;

    private float nextShot;
    public bool fireEnabled;
    public bool isOnRightSide;
    public bool lastEnemyInColumn;

    void Start()
    {
        nextShot = Time.time + Random.Range(1f, 11f);
    }


    void Update()
    {
        if (fireEnabled)
        {
            if (Time.time > nextShot)
            {
                Instantiate(shot, transform.position, Quaternion.identity);
                nextShot = Time.time + Random.Range(1f, 11f);
            }
        }
    }

    public void enableFire()
    {
        fireEnabled = true;
        nextShot = Time.time + Random.Range(1f, 11f);
    }
}
