using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {

    public Rigidbody2D Rigidbody2 { get => GetComponent<Rigidbody2D>(); }
    public SpriteRenderer SpriteRenderer { get => GetComponent<SpriteRenderer>(); }
    
}
