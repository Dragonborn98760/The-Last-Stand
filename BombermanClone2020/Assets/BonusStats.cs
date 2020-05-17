using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    class BonusStats : Pickup
    {
        [SerializeField]
        protected GameObject exploasionUpPrefab;
        [SerializeField]
        protected GameObject speedUpPrefab;
        public BonusStats()
        {

            System.Console.WriteLine(myStats); 

        }

    }
}
