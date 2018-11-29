using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLifeController : MonoBehaviour {

    public int lifes;


    public void recieveDamage()
    {
        lifes--;
        if (lifes <= 0)
        {
            AudioSource audio = gameObject.GetComponent<AudioSource>();
            audio.Play();
            
        }
    }
}
