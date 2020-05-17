using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControler : MonoBehaviour
{
    
    
    //public float for the speed of charactger meaning it can be edited in unity
    public float speed = 5f;

    [SerializeField]
    GameObject bombPrefab;
    [SerializeField]
    GameObject exploasionPrefab;

    GameObject bomb;
    //new rigidbody callout
    private Rigidbody2D characterRigidBody;


    

    
    

    void Start()
    {
        //gets the rigidbody2d for rigidbody
        characterRigidBody = GetComponent<Rigidbody2D>();

        

       

    }

    void Update()
    {
        //if the player presses the respected key (space)...
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //..instantiate new bomb prefab



            GameObject bomb = GameObject.Instantiate(this.bombPrefab, characterRigidBody.transform.position, Quaternion.identity);
            
            

        }
        if (bomb.activeSelf == true)
        {
            bomb.SetActive(false);
        }
        else
        {
            bomb.SetActive(true);
        }





    }
    private void FixedUpdate()
    {

        //float for vertical moves based on the vertical movemeant keys are pressed and on the speed chosen
        float verticalMovemeant = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        
        //float for horizontal moves based on the horizontal movemeant keys are pressed and on the speed chosen
        float horizontalMovemeant = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        
        //creates a vector out of the two floats 
        Vector3 movemeant = new Vector3(horizontalMovemeant, verticalMovemeant);
        
        //changes the velocity of the character according to the vector created and moves the character
        characterRigidBody.velocity = movemeant;

        


    }


    
    
    
    
}
