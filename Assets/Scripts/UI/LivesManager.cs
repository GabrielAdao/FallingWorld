using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
{
    public static int lives;

    Text text;

    private void Awake() {
        
        text = GetComponent<Text>();

        lives = 3;
    }

    private void Update() {
        text.text = "Lives: " + lives;
        GameOver();
    }

    private void GameOver(){
        if(lives < 0){
            SceneManager.LoadScene("GameOver");    
        }
    }
}
