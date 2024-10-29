using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour
{
    Rigidbody rb;
    public int boxId;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void SetPickedState(Transform holder)
    {
        rb.useGravity = false; //detiene la caida del rigid body
        rb.isKinematic = true; //Detiene la colision e interaccion con otros elementos
        transform.parent = holder;
    }
    public void SetDroppedState()
    {
        rb.useGravity = true;
        rb.isKinematic = false;
        transform.parent = null;
    }

    public int ReturnBoxId()
    {
        return boxId;
    }
}
