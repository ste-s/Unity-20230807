using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPlayer : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    Animator animPlayer;
    public float horizontal;
    public float vertical;
    public float velocidade;
    public float eixoX = 1f;
    public bool olhandoDireita = true;

    private void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        animPlayer = GetComponent<Animator>();
        velocidade = 10;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        animPlayer.SetFloat("velocidadeHorizontal", horizontal);

        /*if(horizontal > 0 && !olhandoDireita)
        {
            eixoX = 1;
            olhandoDireita = true;
        }
        else if(horizontal < 0 && olhandoDireita)
        {
            eixoX = -1;
            olhandoDireita = false;
        }*/
        transform.localScale = new Vector3(eixoX, 1, 1);
    }

    private void FixedUpdate()
    {
        rbPlayer.velocity = new Vector2(horizontal * velocidade, vertical * velocidade);
    }
}
