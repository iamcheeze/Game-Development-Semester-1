using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Animator anim;

    private void OnMouseDown()
    {
        anim.Play("ButtonPressed");
        Debug.Log("i am buton");
    }
}
