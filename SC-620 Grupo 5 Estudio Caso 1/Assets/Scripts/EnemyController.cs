using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
         int enemyCount = 0;
        if (other.gameObject.tag == "Bullet")
        {
            enemyCount = enemyCount + 1;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}