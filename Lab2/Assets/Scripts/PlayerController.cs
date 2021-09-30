using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    private float zBound = 7;
    private Rigidbody playerplayerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerplayerRB = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstraintPlayerPosition();
    }

    //Move the player based on arrow key inputs
    void MovePlayer()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        playerplayerRB.AddForce(Vector3.forward * speed * verticalInput);
        playerplayerRB.AddForce(Vector3.right * speed * horizontalInput);

    }

    //Limits the player's movement in the z axis
    void ConstraintPlayerPosition()
    {
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }

        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}
