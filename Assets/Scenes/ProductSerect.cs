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
    UnityEngine.UI.Button Eham;

    UnityEngine.UI.Button IT;
    UnityEngine.UI.Button AM;
    UnityEngine.UI.Button CM;
    UnityEngine.UI.Button NS;



    public GameObject HLText;
    public GameObject BLText;
    public GameObject SLText;
    public GameObject CLText;
    public GameObject WCLText;
    public GameObject ELText;

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
        Eham = GameObject.Find("YesButton5").GetComponent<UnityEngine.UI.Button>();

  



        UpdateHL();
        UpdateBL();
        UpdateSL();
        UpdateCL();
        UpdateWCL();
        UpdateEL();

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
        Eham.interactable = gamesystem.revenue >= gamesystem.eggburger.Revenue && !gamesystem.eggburger.IsMaxLevel();







        UpdateHL();
        UpdateBL();
        UpdateSL();
        UpdateCL();
        UpdateWCL();
        UpdateEL();

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
    void UpdateEL()
    {
        ELText.GetComponent<Text>().text = gamesystem.eggburger.Level.ToString("");
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








    }



