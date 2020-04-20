using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : TileGenerator
{
    
    //overrides the method so it is possible to change where the tiles should spawn
    protected override void PlaceTile(Vector3 offset, int x, int y)
    {


        //places the wall tiles around the earlier places ground tiles
        if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
        {

            base.PlaceTile(offset, x, y);
            

        }
        //and in the middle
        else if (x % 2 == 0 && y % 2 == 0)
        {
            base.PlaceTile(offset, x, y);
            
        }
        
        

    }



}
