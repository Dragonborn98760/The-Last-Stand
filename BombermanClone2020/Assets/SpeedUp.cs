using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    class SpeedUp : BonusStats
    {

        public SpeedUp()
        {


            Instantiate(speedUpPrefab);





        }
        private void OnTriggerEnter(UnityEngine.Collider other)
        {

            myStats.Add("Speed", 20);

        }
    }
}
