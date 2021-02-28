using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public Transform spriteTransform;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(Movingscript.direction == 1)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
            spriteTransform.position = new Vector2(spriteTransform.position.x, spriteTransform.position.y - 0.5f);
        }
        if (Movingscript.direction == 2)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.5f);
            spriteTransform.position = new Vector2(spriteTransform.position.x, spriteTransform.position.y + 0.5f);
        }
        if (Movingscript.direction == 3)
        {
            transform.position = new Vector2(transform.position.x + 0.5f, transform.position.y);
            spriteTransform.position = new Vector2(spriteTransform.position.x + 0.5f, spriteTransform.position.y);
        }
        if (Movingscript.direction == 4)
        {
            transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y);
            spriteTransform.position = new Vector2(spriteTransform.position.x - 0.5f, spriteTransform.position.y);
        }
    }
}
