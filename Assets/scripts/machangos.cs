using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class machangos : MonoBehaviour {
  
     public Text text1;
     public float tiempo;

    // Use this for initialization
    void Start () {
        text1.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > tiempo)
        {
            text1.enabled = true;
        }

    }
}
