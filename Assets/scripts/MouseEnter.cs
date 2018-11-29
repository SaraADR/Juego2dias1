using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseEnter : MonoBehaviour
{
    public Text text;
 
    public void OnMouseOver()
     {
        text.color = Color.green;
      
      
     }

     public void OnMouseEnter()
     {
        text.color = Color.white;
    }

}
