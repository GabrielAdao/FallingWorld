using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public bool _flipX;
    public bool powerUpActive = false;
    public bool barrierPowerUpActive = false;
    public bool slowPowerUpActive = false;

    public PlayerController controller;
    public PowerUpController powerUpController;
    public GameObject barrierPrefab;
    public Vector2 newPosition;

    private void Awake()
    {
        controller = GetComponent<PlayerController>();
        powerUpController = GetComponent<PowerUpController>();
    }

    private void Start()
    {
        newPosition += new Vector2(5, 0);
        

    }

    void Update()
    {
        controller.Rigidbody2.velocity = new Vector2(speed, 0);
        //Left click mouse change direction and flip the image
        if (Input.GetMouseButtonDown(0))
        {
            speed *= -1;
            _flipX = !_flipX;
            controller.SpriteRenderer.flipX = _flipX;
        }

        if (barrierPowerUpActive == true)
        {
            GetComponent<PlayerMove>().barrierPrefab.SetActive(true);
        }
        else
        {
            GetComponent<PlayerMove>().barrierPrefab.SetActive(false);
        }

        if(powerUpActive == true && slowPowerUpActive == false)
        {
            slowPowerUpActive = true;
            powerUpController.StartCoroutine(powerUpController.SlowSpikePowerUp());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spikes")
        {
            LivesManager.lives -= 1;
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SlowSpike")
        {
            powerUpActive = true;
            slowPowerUpActive = false;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Barrier")
        {
            barrierPowerUpActive = true;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "ExtraLife")
        {
            LivesManager.lives += 1;
            Destroy(collision.gameObject);
        }
    }
}
