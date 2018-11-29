using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifes : MonoBehaviour {

    private int lifes = 3;
    public GameObject Panel;


    public void recieveDamage()
    {
        lifes--;
        if (lifes == 2)
        {
            Destroy(GameObject.Find("Life3"));
        }
        else if (lifes == 1)
        {
            Destroy(GameObject.Find("Life2"));
        }
        else if (lifes == 0)
        {
            Destroy(GameObject.Find("Life1"));
        }
        
        if (lifes <= 0)
        {
            Panel.SetActive(true);

        }
    }

    public int GetLifes()
    {
        return this.lifes;

    }
}
