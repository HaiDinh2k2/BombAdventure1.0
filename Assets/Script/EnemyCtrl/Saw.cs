using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public float speed = 2;
    int dir = 1;

    public Transform rightCheck;
    public Transform leftCheck;
    public bool isFacingRight = true;

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * dir * Time.fixedDeltaTime);
        if (Physics2D.Raycast(rightCheck.position, Vector2.down, 2) == false)
            dir = -1;

        if (Physics2D.Raycast(leftCheck.position, Vector2.down, 2) == false)
            dir = 1;

        if (isFacingRight && dir < 0 || !isFacingRight && dir > 0)
            Flip();
    }
    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
    }
}
