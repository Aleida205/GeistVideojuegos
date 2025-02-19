using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]private float speed = 3f;

    private Rigidbody2D playerRb;
    private Vector2 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveZ);
    }



    private void FixedUpdate()   //Este metodo es mejor que el update para manejar movimiento con tiempo//
    {
        playerRb.MovePosition(playerRb.position + moveInput * speed * Time.fixedDeltaTime);
    }




}
