using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamesystem : MonoBehaviour
{
    private int counter = 0;
    public static decimal revenue = 3000000.0m;
    private static decimal rps = 20.0m;
    public GameObject revenueText;
    public decimal GameSpeed = 2;
    [SerializeField] Text GamespeedText;
    public GameObject rpsText;
    public static Ham hamburger = new Ham();
    public static BHam bigburger = new BHam();
    public static SHam shrimpburger = new SHam();
    public static CHam cheeseburger = new CHam();
    public static WCHam wcheeseburger = new WCHam();


    public static Interior interior = new Interior();
    public static Armor armor = new Armor();
    public static Newshop newshop = new Newshop();
    public static CM cm = new CM();


    // Start is called before the first frame update
    void Start()
    {
        UpdateRevenue();
        UpdateGameSpeed();
        UpdateRps();
    }

    // Update is called once per frame
    void Update()
    {
        decimal delta = (decimal)Time.deltaTime;
        GameSpeed = (decimal)Time.deltaTime * 30;
        revenue += rps * delta * GameSpeed;
        if (counter % 60 == 0)
        {
            Debug.Log(revenue);
        }
        UpdateRevenue();
        
    }
    void UpdateRevenue()
    { 
        if(revenueText != null)
        revenueText.GetComponent<Text>().text = revenue.ToString("C0");
    }
    void UpdateGameSpeed()
    {
        GamespeedText.GetComponent<Text>().text = GameSpeed.ToString("00");
    }
    void UpdateRps()
    {
        rpsText.GetComponent<Text>().text = rps.ToString("0.0");
    }
    public void ClickYesButton()
    {
        BuyProduct(hamburger);
    }
    public void ClickYesButton1()
    {
        BuyProduct(bigburger);
    }
    public void ClickYesButton2()
    {
        BuyProduct(shrimpburger);
    }
    public void ClickYesButton3()
    {
        BuyProduct(cheeseburger);
    }
    public void ClickYesButton4()
    {
        BuyProduct(wcheeseburger);
    }
    public void ClickITYesButton()
    {
        BuyProduct(interior);
    }

    public void ClickAMYesButton()
    {
        BuyProduct(armor);
    }
    public void ClickNSYesButton()
    {
        BuyProduct(newshop);
    }
    public void ClickCMYesButton()
    {
        BuyProduct(cm);
    }

    private void BuyProduct(Product product)
    {
        product.Level++;
        revenue -= product.Revenue;
        rps += product.Rps;
    }

}