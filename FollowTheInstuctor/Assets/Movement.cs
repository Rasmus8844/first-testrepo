using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    void Update()
    {
       
        if (Input.GetAxis("Horizontal") != 0)
        {

            transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));

        }


        if (Input.GetAxis("Vertical") != 0)
        {

            transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));

        }

    }
}
