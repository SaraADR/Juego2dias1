using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallPieceController : MonoBehaviour {

    public int lifes;

    public void recieveDamage()
    {
        lifes--;

        if (lifes <= 0)
        {
            Destroy(gameObject);
        }


        Color baseColor = gameObject.GetComponent<SpriteRenderer>().color;
        baseColor = new Color(baseColor.r, baseColor.g, baseColor.b, baseColor.a - 0.25f);

        gameObject.GetComponent<SpriteRenderer>().color = baseColor;
    }

}
