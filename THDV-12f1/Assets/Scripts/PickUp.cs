using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform holdPosition;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 50.0f, Color.red);
        CheckForPickup();
    }
    
    private void CheckForPickup()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 20.0f))
        {
            if(Input.GetKey(KeyCode.F))
            {
                if(hit.transform.gameObject.GetComponent<Pickupable>())
                {
                    //do something
                    hit.transform.gameObject.GetComponent<Pickupable>().SetPickedState(holdPosition);
                }
            }
        }

        if(Input.GetKey(KeyCode.G))
        {
            if(hit.transform.GetComponent<Pickupable>())
            {
                hit.transform.gameObject.GetComponent<Pickupable>().SetDroppedState();
            }
        }
    }
}
