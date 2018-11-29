using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldControl : MonoBehaviour {

    private string text;
    // Update is called once per frame

    void Start () {
        var nombre = gameObject.GetComponent<InputField>();
        var se = new InputField.SubmitEvent();
        se.AddListener(SubmitName);
        nombre.onEndEdit = se;

    }

    public void SubmitName(string guardar)
    {
        text = guardar.ToString();
    }

    public string getName()
    {
        return text;
    }
}
