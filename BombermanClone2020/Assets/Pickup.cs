using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Pickup : MonoBehaviour
    {

    protected int moveSpeed = 1000;

    protected Dictionary<string, int> myStats = new Dictionary<string, int>();

    

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {

            Destroy(gameObject);

        }


        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bomb"))
        {
            gameObject.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
    }


}


