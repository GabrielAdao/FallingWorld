using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesController : MonoBehaviour {

    public int spikeSpeedMax; //variable to define the max speed a spike can fall
    public Vector3 spikePosition; // get the spikes positions to instantiate in the same place
    public GameObject spikePrefab; // get the spike prefab component

    private int spikeSpeed; // variable to get random spike speeds
    private Rigidbody2D rb2;
    

	// Use this for initialization
	void Start () {

        rb2 = GetComponent<Rigidbody2D>();

        spikeSpeed = Random.Range(1, spikeSpeedMax);
        rb2.drag = spikeSpeed;

        spikePosition = transform.position;
	}

    
    private void OnBecameInvisible()
    {
        // Need to check why render in rendering is anot allowed by Unity
        Instantiate(spikePrefab, spikePosition, transform.localRotation);
        ScoreController.score += 1;
        Destroy(this.gameObject);
        ReachGoal();

    }

    

    // Use this to manipulate ScoreController
    private void ReachGoal(){
        if (ScoreController.score >= 10){
            //Debug.Log("Chegou no objetivo");
        }
    }

}
