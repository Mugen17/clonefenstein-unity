using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandgunAmmoPick : MonoBehaviour
{
    public GameObject fakeAmmoClip;
    public AudioSource ammoPickupFX;
    public GameObject pickupDisplay;

    public void OnTriggerEnter(Collider other){
        fakeAmmoClip.SetActive(false);
        ammoPickupFX.Play();
        GlobalAmmo.handgunAmmo += 10;
        pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "CLIP OF BULLETS";
        pickupDisplay.SetActive(true);
    }
}
