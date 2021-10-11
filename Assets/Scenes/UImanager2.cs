using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager2 : MonoBehaviour
{
    [SerializeField] GameObject BPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ClickHamButtonBHamButtonSHamButton()
    {
        BPanel.SetActive(true);
    }


    public void ClickYesButtonNoButton()
    {
        BPanel.SetActive(false);
    }
}
