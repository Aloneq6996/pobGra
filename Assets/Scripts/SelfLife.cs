using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SelfLife : MonoBehaviour
{
    public int Life;
    private TextMeshProUGUI text;

    void Start()
    {
        Life = 100;
        text = GetComponent<TextMeshProUGUI>();
    }

    public void decreaseLife(int dec){
        Life -= dec;
        text.text = "Life: " + Life.ToString();
        if (Life <= 0)
        {
            SceneManager.LoadScene("losePage");
        }
    }
}
