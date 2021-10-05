using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{

    public List<GameObject> activePowerUp = new List<GameObject>();
    public int powerUpIndex;

    void Start()
    {
        powerUpIndex = Random.Range(0, activePowerUp.Count);
        Debug.Log(activePowerUp.Count);

        for (int x = 0; x < activePowerUp.Count; x++)
        {
            activePowerUp[x].SetActive(false);
        }

        InvokeRepeating("ActivePowerOverTime", 6f, 6f);//need balance

    }

    void ActivePowerOverTime()
    {
        activePowerUp[powerUpIndex].SetActive(true);
        Instantiate(activePowerUp[powerUpIndex], RandomPosition(), Quaternion.identity);
        powerUpIndex = Random.Range(0, activePowerUp.Count);
    }

    Vector2 RandomPosition()
    {
        float x, y;
        x = Random.Range(-2.1f, 2.1f);
        y = Random.Range(5.0f, 5.0f);

        return new Vector2(x, y);
    }
}
