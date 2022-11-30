using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    public float moveSpeed = 8f;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
}
