using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public static int score = 7;
    public Text scoreText;

	void Update () {

        scoreText.text = score.ToString();
	}
}
