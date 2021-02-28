using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movingscript : MonoBehaviour
{
    float movespeed = 10f; public static int direction;
    bool up; bool down; bool left; bool right; bool isTouching = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 10f;
        up = Input.GetKey(KeyCode.W);
        down = Input.GetKey(KeyCode.S);
        left = Input.GetKey(KeyCode.A);
        right = Input.GetKey(KeyCode.D);
        if (up)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
            direction = 1;
        }
        if (down)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
            direction = 2;
        }
        if (left)
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
            direction = 3;
        }
        if (right)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
            direction = 4;
        }
    }
}
