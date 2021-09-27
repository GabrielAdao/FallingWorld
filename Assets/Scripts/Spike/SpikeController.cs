using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour
{
    public Rigidbody2D Rigidbody2 { get => GetComponent<Rigidbody2D>(); }

    public List<GameObject> activeSpike1 = new List<GameObject>();
    public int activeSpikeIndex;
    public bool isActive = false;

    private void Start()
    {
        activeSpikeIndex = Random.Range(0, activeSpike1.Count);
        Debug.Log(activeSpike1.Count);

        for (int x = 0; x < activeSpike1.Count; x++)
        {
            activeSpike1[x].SetActive(false);
        }

        InvokeRepeating("ActiveSpikeOverTime", 10f, 10f);//need balance
    }

    void Update()
    {   
    }

    void ActiveSpikeOverTime()
    {
        activeSpike1[activeSpikeIndex].SetActive(true);
        Instantiate(activeSpike1[activeSpikeIndex], activeSpike1[activeSpikeIndex].transform.position, transform.rotation);
        Debug.Log("Rodou 1 vez");
        activeSpike1.Remove(activeSpike1[activeSpikeIndex]);
        activeSpikeIndex = Random.Range(0, activeSpike1.Count);
        if (activeSpike1.Count == 0)
        {
            CancelInvoke();
        }

    }
}
