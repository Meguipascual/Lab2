using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    private Rigidbody playerplayerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerplayerRB = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        playerplayerRB.AddForce(Vector3.forward * speed * verticalInput);
        playerplayerRB.AddForce(Vector3.right * speed * horizontalInput);
    }
}
