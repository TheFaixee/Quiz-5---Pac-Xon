using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridColor : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue = 5;

    // Start is called before the first frame update
    void Start()
    {
        //Game Manager Script Reference
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player")) 
        {
            GetComponent<Renderer>().material.color = Color.blue;
            
        }
        
    }
    private void OnCollisionExit(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player") && gameManager.isGameActive)
        {
            GetComponent<Renderer>().material.color = Color.green;
            //Updating Score whenever Player move on Grid
            gameManager.UpdateScore(5);
        }
    }
}
