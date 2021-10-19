using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSerect : MonoBehaviour
{
    [SerializeField] GameObject HKDPanel;
    [SerializeField] GameObject THDPanel;
    [SerializeField] GameObject KTDPanel;
    [SerializeField] GameObject TBDPanel;
    [SerializeField] GameObject KSDPanel;
    [SerializeField] GameObject TGDPanel;
    [SerializeField] GameObject SKDPanel;
    [SerializeField] GameObject KODPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ClickHKSButton()
    {
        HKDPanel.SetActive(true);
    }
    public void ClickTHSButton()
    {
        THDPanel.SetActive(true);
    }
    public void ClickKTSButton()
    {
        KTDPanel.SetActive(true);
    }
    public void ClickTBSButton()
    {
        TBDPanel.SetActive(true);
    }
    public void ClickKSSButton()
    {
        KSDPanel.SetActive(true);
    }
    public void ClickTGSButton()
    {
        TGDPanel.SetActive(true);
    }
    public void ClickSKSButton()
    {
        SKDPanel.SetActive(true);
    }
    public void ClickKOSButton()
    {
        KODPanel.SetActive(true);
    }

    // Update is called once per frame

}
