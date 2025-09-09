using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; //How many clicks before balloon pops
    public float scaleToIncrease = 0.10f; //Scale increased each time the balloon is clicked

    public int scoreToGive; // Score given for the popped balloon.
    private ScoreManager scoreManager; // A variable to reference the ScoreManger
    public GameObject popEffect; //Reference Pop Effect Particle System

    void Start()
    {
    //    scoreManager = GameObject.Find("ScoreManager").GetComponent<scoreManager>();
    }

    void OnMouseDown()
    {
        // Reduce clicks by one
        clickToPop -= 1;
        //Increase balloon size
        transform.localScale += Vector3.one * scaleToIncrease;

        if (clickToPop == 0)
        {
        //    scoreManager.IncreaseScoreText(scoreToGive); // Increase Score*
        //    Instantiate(popEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        
        }
    
    }
}
