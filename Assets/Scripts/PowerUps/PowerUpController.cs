using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController : MonoBehaviour
{
    public static bool isActive = false;

    public PlayerMove playerMove;

    public IEnumerator SlowSpikePowerUp()
    {
        yield return new WaitForSeconds(5);
        playerMove.powerUpActive = false;
    }
}
