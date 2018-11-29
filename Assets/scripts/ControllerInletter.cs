using UnityEngine;

public class ControllerInletter : MonoBehaviour
{
    public GameObject targetPanel;
    public GameObject panel;

    public void GoToPanel()
    {

        panel.SetActive(false);
        targetPanel.SetActive(true);
    }
}
