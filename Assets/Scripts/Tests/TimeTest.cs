using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    public float waitTime = 5f;

    [SerializeField] private GameObject prefab;
    [SerializeField] private Vector2 spawnPosition;
    [SerializeField] private bool random;

    void Start()
    {
        
    }

    void Update()
    {
        //if(waitTime < Time.timeSinceLevelLoad){
        //     Debug.Log("Passou 5 seg");
        //}
        if (Input.GetMouseButtonDown(0))
        {
            OnSpawnAPrefab();
        }
    }

    public void OnSpawnAPrefab()
    {
        
            if (random)
            {
                float x = Random.Range(-2, 2);
                float y = Random.Range(-4, 4);
                Instantiate(prefab, new Vector2(x, y), Quaternion.identity);
            }
            else
            {
                Instantiate(prefab, spawnPosition, Quaternion.identity);
            }
    }
}
