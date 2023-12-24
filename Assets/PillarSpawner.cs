using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawner : MonoBehaviour
{
    public float timeBtwSpawns;
    public float startTimeSpawns;

    public GameObject pillar;

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            Instantiate(pillar, this.transform.position, this.transform.rotation);
            timeBtwSpawns = startTimeSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
