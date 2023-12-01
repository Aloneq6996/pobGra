using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastCheckpoint : MonoBehaviour
{
    public SelfLife SelfLife;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(){
        SelfLife.decreaseLife(1);
    }
}
