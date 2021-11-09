using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamesystem : MonoBehaviour
{
    private int counter = 0;
    private static decimal revenue = 3000000.0m;
    private static decimal rps = 20.0m;
    public GameObject revenueText;
    public decimal GameSpeed = 2;
    [SerializeField] Text GamespeedText;
    public static Ham hamburger = new Ham();
    public static BHam bigburger = new BHam();
    public static SHam shrimpburger = new SHam();

    public static Interior interior = new Interior();
    public static Armor armor = new Armor();
    public static Newshop newshop = new Newshop();
    public static CM cm = new CM();


    // Start is called before the first frame update
    void Start()
    {
        UpdateRevenue();
        UpdateGameSpeed();
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
    public void ClickYesButton()
    {
        revenue -= 1000.0m;
        rps += 20.0m;
        BuyProduct(hamburger);
    }
    public void ClickYesButton1()
    {
        revenue -= 2000.0m;
        rps += 30.0m;
        BuyProduct(bigburger);
    }
    public void ClickYesButton2()
    {
        revenue -= 3000.0m;
        rps += 40.0m;
        BuyProduct(shrimpburger);
    }

    public void ClickITYesButton()
    {
        revenue -= 10000.0m;
        rps += 50.0m;
        BuyProduct(interior);
    }

    public void ClickAMYesButton()
    {
        revenue -= 9000.0m;
        rps += 45.0m;
        BuyProduct(armor);
    }
    public void ClickNSYesButton()
    {
        revenue -= 10000000.0m;
        rps += 100.0m;
        BuyProduct(newshop);
    }
    public void ClickCMYesButton()
    {
        revenue -= 5000.0m;
        rps += 30.0m;
        BuyProduct(cm);
    }

    private void BuyProduct(Product product)
    {
        product.Level++;
        revenue -= product.Revenue;
        rps += product.Rps;
    }

}