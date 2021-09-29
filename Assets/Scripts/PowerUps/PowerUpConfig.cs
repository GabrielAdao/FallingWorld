using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpConfig : MonoBehaviour
{
    public GameObject powerUpPrefab;
    public Rigidbody2D rb2;
    public Vector2 powerUpVel;
    public Vector2 powerUpPosition;

    public int powerUpSpeed;
    public bool isActive = false;
    void Start()
    {
        powerUpPosition = transform.position;

        powerUpSpeed = 3;

        rb2.velocity = new Vector2(0, -powerUpSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }
}
