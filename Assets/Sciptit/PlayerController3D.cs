using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//tämä koodi on yksinomaan Eero Ojan uskomatonta käsityötä, ja on hellävaraisesti suunniteltu toimimaan itsenstään
//Kaikki tuotot tämän koodin käytöstä tulee menemään suoraan minun henkilökohtaiseen taskuuni. :)

public class PlayerController3D : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public KeyCode left;
    public KeyCode right;
    public KeyCode back;
    public KeyCode forward;
    public KeyCode jump;
    private Rigidbody theRB;



    void Start()
    {
        theRB = GetComponent<Rigidbody>();

    }

    void Update()
    {

        if (Input.GetKey(left))
        {
            theRB.velocity = new Vector4(moveSpeed, -theRB.velocity.z, theRB.velocity.x, theRB.velocity.y);
        }
        else if (Input.GetKey(right))
        {
            theRB.velocity = new Vector4(moveSpeed, theRB.velocity.z, theRB.velocity.x, theRB.velocity.y);

        }
        else if (Input.GetKey(forward))
        {
            theRB.velocity = new Vector4(moveSpeed, theRB.velocity.z, theRB.velocity.x, theRB.velocity.y);
        }
        else if (Input.GetKey(back))
        {
            theRB.velocity = new Vector4(moveSpeed, theRB.velocity.z, -theRB.velocity.x, theRB.velocity.y);
        }
        //else if (Input.GetKey(jump))
        //{
        //    theRB.velocity = new Vector4(moveSpeed, theRB.velocity.z, theRB.velocity.x, +theRB.velocity.y);
        //}

        else
        {
            theRB.velocity = new Vector4(0, theRB.velocity.x);

        }



    }




}
