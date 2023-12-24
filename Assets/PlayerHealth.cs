﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int score;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Death"))
        {
            SceneManager.LoadScene("Flappy Bird");
        }

        if (other.CompareTag("Score"))
        {
            score += 1;
        }
    }
}
