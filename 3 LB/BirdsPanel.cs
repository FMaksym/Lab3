using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsPanel : MonoBehaviour
{
    [SerializeField] private GameObject _birdsPanel;
    [SerializeField] private GameObject _owlPanel;
    [SerializeField] private GameObject _penguinPanel;
    [SerializeField] private GameObject _parrotPanel;


    public void OnClickOwl()
    {
        _birdsPanel.SetActive(false);
        _owlPanel.SetActive(true);
    }

    public void OnClickPenguin()
    {
        _birdsPanel.SetActive(false);
        _penguinPanel.SetActive(true);
    }

    public void OnClickParrot()
    {
        _birdsPanel.SetActive(false);
        _parrotPanel.SetActive(true);
    }

    public void OnClickOwlBackToBirds()
    {
        _birdsPanel.SetActive(true);
        _owlPanel.SetActive(false);
    }

    public void OnClickPenguinBackToBirds()
    {
        _birdsPanel.SetActive(true);
        _penguinPanel.SetActive(false);
    }

    public void OnClickParrotBackToBirds()
    {
        _birdsPanel.SetActive(true);
        _parrotPanel.SetActive(false);
    }
}
