using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructableWallGenerator : TileGenerator
{

    
    protected override void PlaceTile(Vector3 offset, int x, int y)
    {
        
        

        if (x == 3 || y == 3 || x == width -4 || y == height - 4)
        {

            base.PlaceTile(offset, x, y);

        }
        else if (x % 2 == 0 && y % 2 == 0)
        {
            base.PlaceTile(offset, x, y);
        }
        else if (y > 3 && y < height-3 || x > 3 && x < width-3)
        {
            base.PlaceTile(offset, x, y);
        }

        

        //else if (x < 9 && y < 3 || x > -9 && y > -3 || x < 9 && y > -3 || x > -9 && y < 3 )
        {
            //base.PlaceTile(offset, x, y);
        }

    }

}
