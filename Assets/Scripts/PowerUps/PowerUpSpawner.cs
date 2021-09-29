using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{

    public List<GameObject> activePowerUp = new List<GameObject>();
    public List<Vector2> startedPosition = new List<Vector2>();
    public int powerUpIndex;

    void Start()
    {
        powerUpIndex = Random.Range(0, activePowerUp.Count);
        Debug.Log(activePowerUp.Count);

        for (int x = 0; x < activePowerUp.Count; x++)
        {
            activePowerUp[x].SetActive(false);
            startedPosition[x] = activePowerUp[x].transform.position;
        }

        InvokeRepeating("ActivePowerOverTime", 5f, 5f);//need balance

        //startedPosition = activePowerUp[powerUpIndex].transform.position;
    }

    void ActivePowerOverTime()
    {
        activePowerUp[powerUpIndex].SetActive(true);
        Instantiate(activePowerUp[powerUpIndex], startedPosition[powerUpIndex], transform.rotation);
        Debug.Log("Rodou 1 vez");
        powerUpIndex = Random.Range(0, activePowerUp.Count);
        
    }
}
