using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    public void PlayGame (){
        SceneManager.LoadScene("Main");
    }

    public void QuitGame (){
        Application.Quit();
    }

    public void RestartGame(){
        ScoreController.score = 0;
        SceneManager.LoadScene("Main");
    }

    public void ToMainMenu(){
        ScoreController.score = 0;
        SceneManager.LoadScene("Start");
    }
}
