using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SelfLife : MonoBehaviour
{
    public float Life;
    public TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        Life = 100;
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void decreaseLife(int dec){
        Life -= dec;
        text.text = "Life: " + Life.ToString();
    }
}
