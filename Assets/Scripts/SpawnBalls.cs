using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    public GameObject ball;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            Instantiate(ball, transform.position, transform.rotation);
    }
}
