using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCollect : MonoBehaviour
{
    public AudioSource goldPickupFx;
    public GameObject pickupDisplay;

    public void OnTriggerEnter(Collider other){
        GlobalScore.scoreValue+=500;
        goldPickupFx.Play();
        this.GetComponent<BoxCollider>().enabled=false;
        pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "GOLD";
        pickupDisplay.SetActive(true);
        this.transform.parent.gameObject.SetActive(false);
    }
}
