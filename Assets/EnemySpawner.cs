using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //global variable
    public Animator anim;
    private int prevInt = -1;

    public void Choose()
    {
        string[] attacks = new string[] { "Eraser Down Attack", "Eraser Up Attack", "Eraser Middle Attack" };

        //local variable
        int currInt;

        do
        {
            currInt = Random.Range(0, attacks.Length);
        } while (prevInt == currInt);

        prevInt = currInt;

        string attackRandom = attacks[currInt];

        Debug.Log(attackRandom);
        anim.Play(attackRandom);
    }
}
