using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForCompletion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Completion"))
        {
            Destroy(this.gameObject);
        }
    }
}
