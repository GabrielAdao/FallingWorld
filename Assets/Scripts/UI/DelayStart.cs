using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayStart : MonoBehaviour
{
    public GameObject countDown;
    public int countdownTime;
    public Text countdownDisplay;
    
    void Start()
    {
        StartCoroutine(TimeDelay());
    }

    IEnumerator TimeDelay()
    {

        Time.timeScale = 0;
        while (countdownTime > 0)
        {
            
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSecondsRealtime(1f);

            countdownTime--;
        }

        countdownDisplay.text = "GO!";

        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 1;
        countdownDisplay.gameObject.SetActive(false);
    }
}
