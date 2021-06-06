using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandgunPickup : MonoBehaviour
{
    public GameObject realHandgun;
    public GameObject fakeHandgun;
    public AudioSource handgunPickupFX;
    public GameObject pickupDisplay;

    public void OnTriggerEnter(Collider other){
        realHandgun.SetActive(true);
        fakeHandgun.SetActive(false);
        handgunPickupFX.Play();
        this.GetComponent<BoxCollider>().enabled=false;
        pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "HANDGUN";
        pickupDisplay.SetActive(true);
    }
}
