using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductSerect : MonoBehaviour
{
    UnityEngine.UI.Button ham;
    UnityEngine.UI.Button Bham;
    UnityEngine.UI.Button Sham;
    UnityEngine.UI.Button Cham;
    UnityEngine.UI.Button WCham;
    UnityEngine.UI.Button Interior;
    UnityEngine.UI.Button AM;
    UnityEngine.UI.Button CM;
    UnityEngine.UI.Button NS;

    [SerializeField] GameObject BPanel;
    [SerializeField] GameObject BPanel1;
    [SerializeField] GameObject BPanel2;
    [SerializeField] GameObject BPanel3;
    [SerializeField] GameObject BPanel4;
    [SerializeField] GameObject BPanel5;
    [SerializeField] GameObject BPanel6;

    public GameObject HLText;
    public GameObject BLText;
    public GameObject SLText;
    public GameObject CLText;
    public GameObject WCLText;

    public GameObject ITLText;
    public GameObject AMLText;
    public GameObject CMLText;
    public GameObject NSLText;






    // Start is called before the first frame update
    void Start()
    {
        ham = GameObject.Find("YesButton").GetComponent<UnityEngine.UI.Button>();
        Bham = GameObject.Find("YesButton1").GetComponent<UnityEngine.UI.Button>();
        Sham = GameObject.Find("YesButton2").GetComponent<UnityEngine.UI.Button>();
        Cham = GameObject.Find("YesButton3").GetComponent<UnityEngine.UI.Button>();
        WCham = GameObject.Find("YesButton4").GetComponent<UnityEngine.UI.Button>();

        Interior = GameObject.Find("ITYesButton").GetComponent<UnityEngine.UI.Button>();
        AM = GameObject.Find("AMYesButton").GetComponent<UnityEngine.UI.Button>();
        CM = GameObject.Find("CMYesButton").GetComponent<UnityEngine.UI.Button>();
        NS = GameObject.Find("NSYesButton").GetComponent<UnityEngine.UI.Button>();

        UpdateHL();
        UpdateBL();
        UpdateSL();
        UpdateCL();
        UpdateWCL();

        UpdateITL();
        UpdateAML();
        UpdateCML();
        UpdateNSL();

    }

    // Update is called once per frame
    private void Update()
    {
        ham.interactable = gamesystem.revenue >= gamesystem.hamburger.Revenue && !gamesystem.hamburger.IsMaxLevel();
        Bham.interactable = gamesystem.revenue >= gamesystem.bigburger.Revenue && !gamesystem.bigburger.IsMaxLevel();
        Sham.interactable = gamesystem.revenue >= gamesystem.shrimpburger.Revenue && !gamesystem.shrimpburger.IsMaxLevel();
        Cham.interactable = gamesystem.revenue >= gamesystem.cheeseburger.Revenue && !gamesystem.cheeseburger.IsMaxLevel();
        WCham.interactable = gamesystem.revenue >= gamesystem.wcheeseburger.Revenue && !gamesystem.wcheeseburger.IsMaxLevel();

        Interior.interactable = gamesystem.revenue >= gamesystem.interior.Revenue && !gamesystem.interior.IsMaxLevel();
        AM.interactable = gamesystem.revenue >= gamesystem.armor.Revenue && !gamesystem.armor.IsMaxLevel();
        CM.interactable = gamesystem.revenue >= gamesystem.cm.Revenue && !gamesystem.cm.IsMaxLevel();
        NS.interactable = gamesystem.revenue >= gamesystem.newshop.Revenue && !gamesystem.newshop.IsMaxLevel();

        UpdateHL();
        UpdateBL();
        UpdateSL();
        UpdateCL();
        UpdateWCL();

        UpdateITL();
        UpdateAML();
        UpdateCML();
        UpdateNSL();

    }

    void UpdateHL()
    {
        HLText.GetComponent<Text>().text = gamesystem.hamburger.Level.ToString("");
    }
    void UpdateBL()
    {
        BLText.GetComponent<Text>().text = gamesystem.bigburger.Level.ToString("");
    }
    void UpdateSL()
    {
        SLText.GetComponent<Text>().text = gamesystem.shrimpburger.Level.ToString("");
    }
    void UpdateCL()
    {
        CLText.GetComponent<Text>().text = gamesystem.cheeseburger.Level.ToString("");
    }
    void UpdateWCL()
    {
        WCLText.GetComponent<Text>().text = gamesystem.wcheeseburger.Level.ToString("");
    }
    void UpdateITL()
    {
        ITLText.GetComponent<Text>().text = gamesystem.interior.Level.ToString("");
    }
    void UpdateAML()
    {
        AMLText.GetComponent<Text>().text = gamesystem.armor.Level.ToString("");
    }
    void UpdateCML()
    {
        CMLText.GetComponent<Text>().text = gamesystem.cm.Level.ToString("");
    }
    void UpdateNSL()
    {
        NSLText.GetComponent<Text>().text = gamesystem.newshop.Level.ToString("");
    }
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



