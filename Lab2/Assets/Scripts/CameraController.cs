using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offSet;
    public GameObject playerGO;
    
    

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(20, 0, 0));
        offSet = new Vector3(0,5,-5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerGO.transform.position + offSet;
        

    }
}
