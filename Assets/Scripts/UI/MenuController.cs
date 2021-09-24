using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    //Outdated
	// Update is called once per frame
	//void Update () {
        
        //When user click or tap on screen the game starts
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        SceneManager.LoadScene("Main");
    //    }
	//}

    public void PlayGame (){
        SceneManager.LoadScene("Main");
    }

    public void QuitGame (){ 
        Debug.Log("Quit!");
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
