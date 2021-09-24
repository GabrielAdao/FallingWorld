using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    public static int newSpikeSpeed = 1;
    public static int newMaxSpikeSpeed = 1;


    public Rigidbody2D Rigidbody2 { get => GetComponent<Rigidbody2D>(); }
}
