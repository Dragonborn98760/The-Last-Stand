using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : TileGenerator
{
    

    protected override void PlaceTile(Vector3 offset, int x, int y)
    {



        if (x == 0 || y == 0 || x == width - 1 || y == height - 1)
        {

            base.PlaceTile(offset, x, y);
            

        }
        else if (x % 2 == 0 && y % 2 == 0)
        {
            base.PlaceTile(offset, x, y);
            
        }
        
        

    }



}
