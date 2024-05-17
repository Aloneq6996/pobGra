using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastCheckpoint : MonoBehaviour
{
    public SelfLife Life;

    public void OnTriggerEnter2D(Collider2D other){
        Life.decreaseLife(5);
        Destroy(other.gameObject);
    }
}
