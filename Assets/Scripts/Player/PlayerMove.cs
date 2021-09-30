using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public bool _flipX;
    public bool powerUpActive = false;
    public bool barrierPowerUpActive = false;

    public PlayerController controller;
    public GameObject barrierPrefab;
    public Vector2 newPosition;

    private void Awake()
    {
        controller = GetComponent<PlayerController>();
    }

    private void Start()
    {
        newPosition += new Vector2(5, 0);
    }

    void Update()
    {
        //Left click mouse change direction and flip the image
        if (Input.GetMouseButtonDown(0))
        {
            speed *= -1;
            _flipX = !_flipX;
            controller.SpriteRenderer.flipX = _flipX;
        }

        controller.Rigidbody2.velocity = new Vector2(speed, 0);


        if (barrierPowerUpActive == true)
        {
            GetComponent<PlayerMove>().barrierPrefab.SetActive(true);
        }
        else
        {
            GetComponent<PlayerMove>().barrierPrefab.SetActive(false);
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
            Debug.Log(powerUpActive);
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
