using UnityEngine;
using UnityEngine.UI;

public class PanelNavigation : MonoBehaviour
{
    public GameObject[] panels;
    private int currentPanelIndex = 0;
    public void GoToNextPanel()
    {
        panels[currentPanelIndex].SetActive(false);
        currentPanelIndex = (currentPanelIndex + 1) % panels.Length;
        panels[currentPanelIndex].SetActive(true);
    }
    public void GoToPreviousPanel()
    {
        panels[currentPanelIndex].SetActive(false);
        currentPanelIndex = (currentPanelIndex - 1 + panels.Length) % panels.Length;
        panels[currentPanelIndex].SetActive(true);
    }
}