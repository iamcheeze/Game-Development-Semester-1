using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;

    public float jumpPower;

    public Animator anim;

    public float scaleX = 1;
    public float scaleY = 1;

    // Start is called before the first frame update
    void Start()
    {
        scaleX = 1;
        scaleY = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(scaleX, scaleY, 1);

        anim.SetBool("isGrounded (Animator)", isGrounded());

        if (Input.GetKeyDown(KeyCode.W) && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            StartCoroutine(Bouncy(0.625f, 1.4f, 0.2f));
        }

        if (Input.GetKeyUp(KeyCode.W) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        if (rb.velocity.y < 0)
        {
            rb.gravityScale = 8;
        }
        else
        {
            rb.gravityScale = 5;
        }
    }

    public bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    public IEnumerator Bouncy(float scaleXStartEnd, float scaleYStartEnd, float time)
    {
        //stretch it out
        scaleX = scaleXStartEnd;
        scaleY = scaleYStartEnd;
        //wait for a lil
        yield return new WaitForSeconds(time);
        //return it to normal
        scaleX = 1;
        scaleY = 1;
    }
}
