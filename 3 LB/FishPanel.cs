using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPanel : MonoBehaviour
{
    [SerializeField] private GameObject _fishPanel;
    [SerializeField] private GameObject _hummerheadSharkPanel;
    [SerializeField] private GameObject _clownFishPanel;
    [SerializeField] private GameObject _mantaRayPanel;


    public void OnClickHummerheadShark()
    {
        _fishPanel.SetActive(false);
        _hummerheadSharkPanel.SetActive(true);
    }

    public void OnClickClownFish()
    {
        _fishPanel.SetActive(false);
        _clownFishPanel.SetActive(true);
    }

    public void OnClickMantaRay()
    {
        _fishPanel.SetActive(false);
        _mantaRayPanel.SetActive(true);
    }

    public void OnClickHummerheadSharkBackToFish()
    {
        _fishPanel.SetActive(true);
        _hummerheadSharkPanel.SetActive(false);
    }

    public void OnClickClownFishBackToFish()
    {
        _fishPanel.SetActive(true);
        _clownFishPanel.SetActive(false);
    }

    public void OnClickMantaRayBackToFish()
    {
        _fishPanel.SetActive(true);
        _mantaRayPanel.SetActive(false);
    }
}
