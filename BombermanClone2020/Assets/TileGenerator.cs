using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{

    [SerializeField]
    GameObject tile;

    [SerializeField]
    protected int width = 5;

    [SerializeField]
    protected int height = 5;

    BoxCollider2D boxCollider;
    
    void Start()
    {

        

        Vector3 offset = new Vector2(width / 2f - 0.5f, height / 2f - 0.5f);
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                PlaceTile(offset, x, y);
                
            }

            
        }

        
       
    }

    



    protected virtual void PlaceTile(Vector3 offset, int x, int y)
    {
        GameObject newTile = Instantiate(tile, new Vector3(x, y, transform.position.z) - offset, Quaternion.identity);

        newTile.name = "( " + x + " , " + y + " )";

        newTile.transform.parent = this.transform;

    }

    
}
