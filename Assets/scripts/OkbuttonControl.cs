using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkbuttonControl : MonoBehaviour {

    public GameObject targetPanel;

    public void ChangePanel()
    {
        targetPanel.SetActive(true);
    }

}
