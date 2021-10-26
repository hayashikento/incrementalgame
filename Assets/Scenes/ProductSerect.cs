using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductSerect : MonoBehaviour
{
    [SerializeField] GameObject BPanel;
    [SerializeField] GameObject BPanel1;
    [SerializeField] GameObject BPanel2;
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




    public void ClickNoButton()
    {
        BPanel.SetActive(false);
    }
}
