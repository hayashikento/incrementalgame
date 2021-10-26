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
    public int lebel = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateRevenue();
    }

    // Update is called once per frame
    void Update()
    {
        decimal delta = (decimal)Time.deltaTime;
        revenue += rps * delta;
        if (counter % 60 == 0)
        {
            Debug.Log(revenue);
            UpdateRevenue();
        }

        
    }
    void UpdateRevenue()
    { 
        if(revenueText != null)
        revenueText.GetComponent<Text>().text = revenue.ToString("C0");
    }
    public void ClickYesButton()
    {
        revenue -= 1000.0m;
        rps += 20.0m; 
    }
    public void ClickYesButton1()
    {
        revenue -= 2000.0m;
        rps += 30.0m;
    }
    public void ClickYesButton2()
    {
        revenue -= 3000.0m;
        rps += 40.0m;
    }
}