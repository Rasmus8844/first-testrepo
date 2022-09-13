using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody playerbody;
    

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            Jump();
        }
    }

    private void Jump()
    {
        playerbody.AddForce(Vector3.up * 2f);
        
    }
}
