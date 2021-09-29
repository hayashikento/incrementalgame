using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamesystem : MonoBehaviour
{
    private int counter = 0;
    private float revenue = 0.0f;
    private float rps = 20.0f;
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
        }

        
    }
    void UpdateRevenue()
    { 
        revenueText.GetComponent<Text>().text = revenue.ToString("C0");
    }
}