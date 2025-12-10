using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float upForce = 200.0f;

    private bool IsDead = false;
    private Rigidbody2D rb2d;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        animator = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsDead == false)
        {
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce (new Vector2(0, upForce));
                animator.SetTrigger("Flap");
            }
        }
    }

    // Checking Death
    void OnCollisionEnter2D ()
    {
        IsDead = true;
        animator.SetTrigger("Dead");
    }
}
