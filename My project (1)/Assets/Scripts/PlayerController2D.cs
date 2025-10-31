using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [Header("Player Settings")]
    public float moveSpeed;
    public float jumpForce;
    public bool isGrounded;
    public int bottomBound = -4;
    [Header("Score")]
    public int score;
    public SpriteRenderer sr;
    
    
    public Rigidbody2D rig;
    public TextMeshProUGUI scoreText;
    public void GameOver ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void AddScore (int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }

    void FixedUpdate ()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rig.linearVelocity = new Vector2(moveInput * moveSpeed, rig.linearVelocity.y);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if(transform.position.y < bottomBound)
        {
            GameOver();
        }
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.GetContact(0).normal == Vector2.up)
        {
            isGrounded = true;
        }
    }
    
}
