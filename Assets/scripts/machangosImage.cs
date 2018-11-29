using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class machangosImage : MonoBehaviour {
  
     public Image image1;
     public float tiempo;

    // Use this for initialization
    void Start () {
        image1.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > tiempo)
        {
            image1.enabled = true;
        }

    }
}
