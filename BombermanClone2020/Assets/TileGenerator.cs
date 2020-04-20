using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    //gameobject field to place a prefab in which is supposed to spawn
    [SerializeField]
    GameObject tile;
    //editable int for width of the playing field
    [SerializeField]
    protected int width = 5;
    //editable int for height of the playing field 
    [SerializeField]
    protected int height = 5;
    
    void Start()
    {

        
        //offset for the board so it is created in the middle of the game
        Vector3 offset = new Vector2(width / 2f - 0.5f, height / 2f - 0.5f);

        //loop for creating the board
        //for each x number it creates...
        for (int x = 0; x < width; x++)
        {   
            //... it creates tiles on y axle...
            for (int y = 0; y < height; y++)
            {
                //... and places them based on offset, x and y in the game
                PlaceTile(offset, x, y);
                
            }

            
        }

        
       
    }

    


    //placetile method for placing new tiles
    protected virtual void PlaceTile(Vector3 offset, int x, int y)
    {
        //instantiates new tiles 
        GameObject newTile = Instantiate(tile, new Vector3(x, y, transform.position.z) - offset, Quaternion.identity);
        //gives it the name of the coordinates of the tile 
        newTile.name = "( " + x + " , " + y + " )";
        // and groups them all under the game object in the hierarchy 
        newTile.transform.parent = this.transform;

    }

    
}
