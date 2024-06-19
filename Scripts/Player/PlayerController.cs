using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Variables")]
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpPower = 3f;

    private Rigidbody2D playerRb;
    private BoxCollider2D playerCol;

    [Header("GroundCheck")] 
    [SerializeField] private Transform RayStartPosition;
    [SerializeField] private float rayLength = 0.1f;
    [SerializeField] private LayerMask groundLayer;


    private InGameUI inGameUI;

    private void Awake()
    {
        playerCol = GetComponent<BoxCollider2D>();
        playerRb = GetComponent<Rigidbody2D>();
        inGameUI = FindObjectOfType<InGameUI>();
    }

    private void Update()
    {
        PlayerMovement();
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            inGameUI.ShowLooseScreen();
        }

        if (other.gameObject.CompareTag("Goal"))
        {
            inGameUI.ShowWinScreen();
        }
    }

    private void PlayerMovement()
    {
        playerRb.velocity = new Vector2(speed, playerRb.velocity.y);
    }

    void OnJump()
    {
        if (GroundCheck())
        {
            playerRb.AddForce(new Vector2(playerRb.velocity.x, jumpPower), ForceMode2D.Impulse);
        }
    }

    private bool GroundCheck()
    {
        return Physics2D.Raycast(RayStartPosition.position, Vector2.down, rayLength, groundLayer);
    }
}
