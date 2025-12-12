using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Check your godamn code the ground litterally flew away lol it's video 7/10


public class RepeatingBackground : MonoBehaviour
{

    private BoxCollider2D GrassCollider;
    private float GrassHorizontalLength;

    // Start is called before the first frame update
    void Start()
    {
        GrassCollider = GetComponent<BoxCollider2D> ();
        GrassHorizontalLength = GrassCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -GrassHorizontalLength);
        {
            RepositionBackground ();
        }
    }

    private void RepositionBackground()
    {
        Vector2 GrassOffset = new Vector2(GrassHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + GrassOffset;
    }
}
