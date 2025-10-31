using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 moveOffset;
    private Vector3 startPos;
    private Vector3 targetPos;
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerController>().GameOver();
        }
    }
    void Start()
    {
        startPos = transform.position;
        targetPos = startPos;

    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        if (transform.position == startPos)
        {
            targetPos = startPos + moveOffset;

        }
        {
            targetPos = startPos;
        }
    }
        
    
        
}
