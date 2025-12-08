using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

    private bool IsDead = false;
    private Rigidbody2D rgb2d;

{
    // Start is called before the first frame update
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown (0))
            {
                rgb2d.velocity == Vector2.zero; 
            }
        }
    }
}
