using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControler : MonoBehaviour
{
    
    [SerializeField]
    GameObject Bomb;

    public float speed = 5f;

    Vector3 bombPlacemeant;

    private Rigidbody2D characterRigidBody;

    private void Start()
    {
        characterRigidBody = GetComponent<Rigidbody2D>();

        bombPlacemeant = new Vector3(characterRigidBody.transform.position.x, characterRigidBody.transform.position.y, characterRigidBody.transform.position.z);

    }

    private void FixedUpdate()
    {


        float verticalMovemeant = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float horizontalMovemeant = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 movemeant = new Vector3(horizontalMovemeant, verticalMovemeant);

        characterRigidBody.velocity = movemeant;

        


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBomb = Instantiate(Bomb, characterRigidBody.transform.position, Quaternion.identity);

        } 
    }
    
}
