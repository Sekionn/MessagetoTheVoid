using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndThrow : MonoBehaviour
{
    float deltaX, deltaY;
    Rigidbody2D rigidBody;
    bool allowMove = false;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        PhysicsMaterial2D mat = new PhysicsMaterial2D();
        mat.bounciness = 0.75f;
        mat.friction = 0.4f;
        GetComponent<CircleCollider2D>().sharedMaterial = mat;
    }


    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                        allowMove = true;

                        rigidBody.freezeRotation = true;
                        rigidBody.velocity = new Vector2(0,0);
                        rigidBody.gravityScale = 0;
                        GetComponent<CircleCollider2D>().sharedMaterial = null;

                    }
                    break;
            }
        }
    }
}
