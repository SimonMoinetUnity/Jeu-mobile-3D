using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject levelPanel;
    public GameObject optionsPanel;

    public bool levelPanelIsOpen = false;

    public void Play()
    {
        levelPanel.SetActive(true);
        levelPanelIsOpen = true;
    }

    public void Options()
    {
        optionsPanel.SetActive(true);
    }

    public void Retour()
    {
        if (levelPanelIsOpen)
        {
            levelPanel.SetActive(false);
        }
        else
        {
            optionsPanel.SetActive(false);
        }
        
    }
}
