using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField] GameObject NPanel;
    [SerializeField] GameObject SPPanel;
    [SerializeField] GameObject ISPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        BackToN();
    }

    // Update is called once per frame
    public void ClickNButton()
    {
        NPanel.SetActive(true);
        SPPanel.SetActive(false);
        ISPanel.SetActive(false);
    }
    public void ClickSPButton()
    {
        NPanel.SetActive(false);
        SPPanel.SetActive(true);
        ISPanel.SetActive(false);
    }
    public void ClickISButton()
    {
        NPanel.SetActive(false);
        SPPanel.SetActive(false);
        ISPanel.SetActive(true);
    }
    public void BackToN()
    {
        NPanel.SetActive(true);
        SPPanel.SetActive(false);
        ISPanel.SetActive(false);
    }

}
