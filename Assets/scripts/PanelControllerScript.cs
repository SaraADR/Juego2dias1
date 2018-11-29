using UnityEngine;

public class PanelControllerScript : MonoBehaviour
{
    
    public void GoToPanel(GameObject targetPanel)
    {
        this.gameObject.SetActive(false);
        targetPanel.SetActive(true);
    }
}
