using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GridManager : MonoBehaviour
{
    public GameObject gridCellPrefabs;
    private GameObject[,] gameGrid;

    private int height = 15;
    private int width = 15;
    private float gridSpaceSize = 1.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        

        CreateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creating Grid
    private void CreateGrid()
    {
        

        gameGrid = new GameObject[height, width];
        

        for(int z = 0; z < height; z++)
        {
            for(int x = 0; x < width; x++)
            {
                gameGrid[x, z] = Instantiate(gridCellPrefabs, new Vector3(x * gridSpaceSize,0, z * gridSpaceSize), Quaternion.identity);
                //gameGrid[x, z].GetComponentInChildren<TextMesh>().text = birdsList[Random.Range(0, birdsList.Count)];

            }
        }
    }

    //Changing color of Player when creating Grid
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
