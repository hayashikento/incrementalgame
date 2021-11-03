using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ham : MonoBehaviour
{
    public int lebel = 0;
    public static decimal revenue = 3000000.0m;
    public static decimal rps = 20.0m;
    private int count;
    [SerializeField] GameObject YesButton;
    // Start is called before the first frame update
    public void ClickYesButton()
    {
        count += 1;
        while (count <=10)
        {
            lebel += 1;
            revenue -= 200000 * count;
            rps += 40.0m * count;
        }
    }


    // Update is called once per frame

}
