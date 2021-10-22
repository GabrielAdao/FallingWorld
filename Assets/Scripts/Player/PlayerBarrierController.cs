using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBarrierController : MonoBehaviour
{
    public PlayerMove playerMove;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SideSpikes")
        {
            playerMove.barrierPowerUpActive = false;
        }
    }
}
