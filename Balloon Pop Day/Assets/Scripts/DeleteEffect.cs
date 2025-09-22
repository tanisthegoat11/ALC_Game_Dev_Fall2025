using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class DeleteEffect : MonoBehaviour
{
    private float timer;
    void Start()
    {
        timer = 2f;
        Destroy(gameObject, timer);
    }
}


