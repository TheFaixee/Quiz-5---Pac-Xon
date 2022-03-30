using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private GameManager gameManager;
    public float speed = 5;
    private float horizontal;
    private float vertical;
    //private float offset = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        //Game Manager Script Reference
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player Movement
        horizontal = Input.GetAxis("Horizontal" );
        vertical = Input.GetAxis("Vertical" );
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical );
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal  );
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Collision with Enemy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            gameManager.GameOver();
        }
        //to create boxes on Ground
        GetComponent<Renderer>().material.color = Color.red;
    }
}
