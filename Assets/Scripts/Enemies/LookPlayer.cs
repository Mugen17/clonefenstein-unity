using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    public Transform thePlayer;
    public GameObject theEnemy;

    void Update()
    {
        theEnemy.transform.LookAt(thePlayer);
    }
}
