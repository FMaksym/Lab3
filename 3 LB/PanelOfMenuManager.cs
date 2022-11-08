using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOfMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _mammalsPanel;
    [SerializeField] private GameObject _birdsPanel;
    [SerializeField] private GameObject _fishPanel;
    [SerializeField] private GameObject _reptilesPanel;

    public void OnClickMammals()
    {
        _menuPanel.SetActive(false);
        _mammalsPanel.SetActive(true);
    }

    public void OnClickBirds()
    {
        _menuPanel.SetActive(false);
        _birdsPanel.SetActive(true);
    }

    public void OnClickFish()
    {
        _menuPanel.SetActive(false);
        _fishPanel.SetActive(true);
    }

    public void OnClickReptiles()
    {
        _menuPanel.SetActive(false);
        _reptilesPanel.SetActive(true);
    }

    public void OnClickMammalsBackToMenu()
    {
        _menuPanel.SetActive(true);
        _mammalsPanel.SetActive(false);
    }

    public void OnClickBirdsBackToMenu()
    {
        _menuPanel.SetActive(true);
        _birdsPanel.SetActive(false);
    }

    public void OnClickFishBackToMenu()
    {
        _menuPanel.SetActive(true);
        _fishPanel.SetActive(false);
    }

    public void OnClickReptilesBackToMenu()
    {
        _menuPanel.SetActive(true);
        _reptilesPanel.SetActive(false);
    }
}
