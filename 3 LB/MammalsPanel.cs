using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MammalsPanel : MonoBehaviour
{
    [SerializeField] private GameObject _mammalsPanel;
    [SerializeField] private GameObject _tigerPanel;
    [SerializeField] private GameObject _elephantPanel;
    [SerializeField] private GameObject _deerPanel;


    public void OnClickTiger()
    {
        _mammalsPanel.SetActive(false);
        _tigerPanel.SetActive(true);
    }

    public void OnClickElephant()
    {
        _mammalsPanel.SetActive(false);
        _elephantPanel.SetActive(true);
    }

    public void OnClickDeer()
    {
        _mammalsPanel.SetActive(false);
        _deerPanel.SetActive(true);
    }

    public void OnClickTigerBackToMammals()
    {
        _mammalsPanel.SetActive(true);
        _tigerPanel.SetActive(false);
    }

    public void OnClickElephantBackToMammals()
    {
        _mammalsPanel.SetActive(true);
        _elephantPanel.SetActive(false);
    }

    public void OnClickDeerBackToMammals()
    {
        _mammalsPanel.SetActive(true);
        _deerPanel.SetActive(false);
    }

}
