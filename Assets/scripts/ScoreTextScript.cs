using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour {

    private Text text;
    private int scoreValue = 0;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "" + GetScoreValue();
	}

    public void SetScoreValue(int scoreValue)
    {
        this.scoreValue += scoreValue;
    }

    public int GetScoreValue()
    {
        return this.scoreValue;
    }
}
