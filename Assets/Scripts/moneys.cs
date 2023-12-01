using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class moneys : MonoBehaviour
{
    public int money;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        money = 200;
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void moneyDecrease(int dec){
        money -= dec;
        text.text = "money: " + money.ToString();
    }
}
