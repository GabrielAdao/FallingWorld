using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideSpike : MonoBehaviour
{
    public bool takeDamageOverTime = true;

    public PlayerMove playerMove;

    private void Awake()
    {
        playerMove = GetComponent<PlayerMove>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (takeDamageOverTime)
            {
                StartCoroutine(DamageTimer());
                LivesManager.lives -= 1;
            }  
        }
    }

    IEnumerator DamageTimer()
    {
        takeDamageOverTime = false;
        yield return new WaitForSeconds(1);
        takeDamageOverTime = true;
    }
}
