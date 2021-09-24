using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierPowerUpSpawner : MonoBehaviour
{
    public GameObject powerUpPrefab;
    public Rigidbody2D rb2;
    public Vector2 powerUpVel;
    public Vector2 powerUpPosition;

    public int powerUpSpeed;
    public bool isActive = false;


    private void Start()
    {
        powerUpPosition = transform.position;

        powerUpSpeed = 3;

        rb2.velocity = new Vector2(0, -powerUpSpeed);
    }

    private void Update()
    {
        if (ScoreController.score == 15 && isActive == false)
        {
            isActive = true;
            Instantiate(powerUpPrefab, powerUpPosition, transform.localRotation);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(this.gameObject);
        }
    }
}
