using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    class ExploasionUp : BonusStats
    {

        public ExploasionUp()
        {
            

            Instantiate(exploasionUpPrefab);


        }

        private void OnTriggerEnter(UnityEngine.Collider other)
        {
            
            myStats.Add("ExploasionSize", 2);

        }




    }
}
