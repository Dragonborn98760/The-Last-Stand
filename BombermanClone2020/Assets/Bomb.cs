using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Bomb: MonoBehaviour
    {
    
    private int sizeOfExploasion = 1;
    
    [SerializeField]
    GameObject bombPrefab;
    [SerializeField]
    GameObject exploasionPrefab;

    


     void Start()
    {


        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (gameObject.CompareTag("Breakable"))
        {

            UnityEngine.Object.Destroy(GameObject.FindGameObjectWithTag("Breakable"));

        }

    }
    
}

