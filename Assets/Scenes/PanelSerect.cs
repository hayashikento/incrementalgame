using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSerect : MonoBehaviour
{
    [SerializeField] GameObject HKPanel;
    [SerializeField] GameObject THPanel;
    [SerializeField] GameObject KTPanel;
    [SerializeField] GameObject TBPanel;
    [SerializeField] GameObject KSPanel;
    [SerializeField] GameObject TGPanel;
    [SerializeField] GameObject SKPanel;
    [SerializeField] GameObject KOPanel;
    [SerializeField] GameObject ShopMorePanel; 
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ClickHKButton()
    {
        HKPanel.SetActive(true);
    }
    public void ClickTHButton()
    {
        THPanel.SetActive(true);
    }
    public void ClickKTButton()
    {
        KTPanel.SetActive(true);
    }
    public void ClickTBButton()
    {
        TBPanel.SetActive(true);
    }
    public void ClickKSButton()
    {
        KSPanel.SetActive(true);
    }
    public void ClickTGButton()
    {
        TGPanel.SetActive(true);
    }
    public void ClickSKButton()
    {
        SKPanel.SetActive(true);
    }
    public void ClickKOButton()
    {
        KOPanel.SetActive(true);
    }

    public void ClickShopMoreButton()
    {
        ShopMorePanel.SetActive(true);
    }
    public void ClickCButton()
    {
        HKPanel.SetActive(false);
        THPanel.SetActive(false);
        KTPanel.SetActive(false);
        TBPanel.SetActive(false);
        KSPanel.SetActive(false);
        TGPanel.SetActive(false);
        SKPanel.SetActive(false);
        KOPanel.SetActive(false);
    }
}
