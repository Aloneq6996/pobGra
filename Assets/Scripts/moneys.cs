using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class moneys : MonoBehaviour
{
    public int money;
    private TextMeshProUGUI text;

    void Start()
    {
        money = 200;
        text = GetComponent<TextMeshProUGUI>();
    }

    public void moneyDecrease(int dec){
        money -= dec;
        text.text = "money: " + money.ToString();
    }public void moneyIncrease(int dec){
        money += dec;
        text.text = "money: " + money.ToString();
    }
}
