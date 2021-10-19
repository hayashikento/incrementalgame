using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamesystem : MonoBehaviour
{
    private int counter = 0;
    private static float revenue = 30000.0f;
    private static float rps = 20.0f;
    public GameObject revenueText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateRevenue();
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Time.deltaTime;
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
        revenue -= 1000.0f;
        rps += 20.0f; 
    }
    public void ClickYesButton1()
    {
        revenue -= 2000.0f;
        rps += 30.0f;
    }
    public void ClickYesButton2()
    {
        revenue -= 3000.0f;
        rps += 40.0f;
    }
}