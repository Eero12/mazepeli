using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorcontroller : MonoBehaviour
{

    public GameObject Door;
    public GameObject Door2;
    public bool doorIsOpening;
    void Update()
    {
        if(doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
            if (Door2 != null)
            {

            Door2.transform.Translate(Vector3.up * Time.deltaTime * 5);
            }
        }
        if (Door.transform.position.y > 6.8f)
        {
            doorIsOpening = false;
        }
    }
    
    void OnMouseDown()
    {
        doorIsOpening = true;
    }


}

