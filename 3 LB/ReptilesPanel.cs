using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReptilesPanel : MonoBehaviour
{
    [SerializeField] private GameObject _reptilesPanel;
    [SerializeField] private GameObject _crocodilePanel;
    [SerializeField] private GameObject _turtlePanel;
    [SerializeField] private GameObject _toadPanel;


    public void OnClickCrocodile()
    {
        _reptilesPanel.SetActive(false);
        _crocodilePanel.SetActive(true);
    }

    public void OnClickTurtle()
    {
        _reptilesPanel.SetActive(false);
        _turtlePanel.SetActive(true);
    }

    public void OnClickToad()
    {
        _reptilesPanel.SetActive(false);
        _toadPanel.SetActive(true);
    }

    public void OnClickCrocodileBackToReptiles()
    {
        _reptilesPanel.SetActive(true);
        _crocodilePanel.SetActive(false);
    }

    public void OnClickTurtleBackToReptiles()
    {
        _reptilesPanel.SetActive(true);
        _turtlePanel.SetActive(false);
    }

    public void OnClickToadBackToReptiles()
    {
        _reptilesPanel.SetActive(true);
        _toadPanel.SetActive(false);
    }
}
