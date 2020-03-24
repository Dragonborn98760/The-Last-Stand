using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControler : MonoBehaviour
{
        
    public float speed = 5f;

    private Rigidbody2D characterRigidBody;

    private void Start()
    {
        characterRigidBody = GetComponent<Rigidbody2D>(); 
    }
    private void FixedUpdate()
    {


        float verticalMovemeant = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float horizontalMovemeant = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 movemeant = new Vector3(horizontalMovemeant, verticalMovemeant);

        characterRigidBody.velocity = movemeant;
        
        

    }
}
