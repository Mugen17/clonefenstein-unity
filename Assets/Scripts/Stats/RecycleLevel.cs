using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecycleLevel : MonoBehaviour
{
    public GameObject gameOver;
    void Start()
    {
        GlobalLives.livesValue -= 1;
        if(GlobalLives.livesValue == 0){
            gameOver.SetActive(true);
        }else{
            SceneManager.LoadScene(2);
        }
    }
}
