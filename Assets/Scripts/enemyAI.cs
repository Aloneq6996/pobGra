using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyAI : MonoBehaviour
{
    public int numOfCheckpoints;
    private Rigidbody2D rb;
    public float speed;
    private int CurrCheckpoint = 0;
    private string checkPoint;
    public bool isLast;

    public float enemyLife;

    void Start()
    {

    }

    void Update()
    {
        float step = speed * Time.deltaTime;

        checkPoint = CurrCheckpoint.ToString();
        transform.position = Vector2.MoveTowards(transform.position, GameObject.Find(checkPoint).transform.position, step);
        if (GameObject.Find(CurrCheckpoint.ToString()).transform.position == transform.position)
        {
            CurrCheckpoint += 1;
        }
        if (transform.position.x > 11)
        {
            Destroy(gameObject);

            if (isLast)
            {
                SceneManager.LoadScene("winPage");
            }
        }
    }

    public void decreaseLifeEnemy(int dmg){
        enemyLife -= dmg;
    }
}