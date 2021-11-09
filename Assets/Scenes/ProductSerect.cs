using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductSerect : MonoBehaviour
{
    [SerializeField] GameObject BPanel;
    [SerializeField] GameObject BPanel1;
    [SerializeField] GameObject BPanel2;
    [SerializeField] GameObject BPanel3;
    [SerializeField] GameObject BPanel4;
    [SerializeField] GameObject BPanel5;
    [SerializeField] GameObject BPanel6;
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
        BPanel1.SetActive(true);
    }
    public void ClickSHamButton()
    {
        BPanel2.SetActive(true);
    }

    public void ClickITButton()
    {
        BPanel3.SetActive(true);
    }
    public void ClickAMButton()
    {
        BPanel4.SetActive(true);
    }
    public void ClickCMButton()
    {
        BPanel5.SetActive(true);
    }
    public void ClickNSButton()
    {
        BPanel6.SetActive(true);
    }



    public void ClickNoButton()
    {
        BPanel.SetActive(false);
    }
}
