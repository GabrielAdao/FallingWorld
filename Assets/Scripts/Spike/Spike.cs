using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public Vector2 spikePosition; // get the spikes positions to instantiate in the same place
    public GameObject spikePrefab; // get the spike prefab component
    public Rigidbody2D rb2;
    public Vector2 vel;

    public PowerUpController powerUpController;
    public PlayerMove playerMove;

    public bool isSlowed = false;
    public int spikeSpeed; // variable to get random spike speeds

    public int spikeSpeedSlowed = 1;

    private void Awake()
    {
        powerUpController = GetComponent<PowerUpController>(); 
    }

    void Start()
    {
        spikePosition = transform.position;
        spikeSpeed = Random.Range(2, 6);
    }
    private void Update()
    {
        if (playerMove.powerUpActive == true)
        {
            rb2.velocity = new Vector2(0, -1);
        }
        else
        {
            rb2.velocity = new Vector2(0, -spikeSpeed);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor") || other.gameObject.CompareTag("Player"))
        {
            Instantiate(spikePrefab, spikePosition, transform.localRotation);
            ScoreController.score += 1;
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Barrier"))
        {
            Instantiate(spikePrefab, spikePosition, transform.localRotation);
            playerMove.barrierPowerUpActive = false;
            Destroy(gameObject);   
        }
    }
}
