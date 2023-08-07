using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class scrQuadrado : MonoBehaviour
{
    Rigidbody2D rbQuadrado;
    public float horizontal;
    public float vertical;
    public float velocidade = 10.0f;

    void Start()
    {
        rbQuadrado = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rbQuadrado.velocity = new Vector2(horizontal * velocidade, vertical * velocidade);
    }
}