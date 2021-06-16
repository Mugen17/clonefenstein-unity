using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth = 20;
    public bool enemyDead = false;
    public GameObject enemyAI;
    public GameObject theEnemy;

    void DamageEnemy(int damageAmount){
        enemyHealth-=damageAmount;
        Debug.Log("LOL!");
    }

    void Update()
    {
        Debug.Log(enemyHealth);
        Debug.Log(enemyDead);
        if(enemyHealth<=0 && enemyDead==false){
            enemyDead = true;
            theEnemy.GetComponent<Animator>().Play("Death");
            enemyAI.SetActive(false);
        }
    }
}
