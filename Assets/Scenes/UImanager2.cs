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
    public void ClickHamButton()
    {
        BPanel.SetActive(true);
    }

    public void ClickBHamButton()
    {
        BPanel.SetActive(true);
    }
    public void ClickNoButton()
    {
        BPanel.SetActive(false);
    }
}
