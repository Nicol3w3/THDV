using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform holdPosition;
    private Pickupable currentPickupable; // Variable para almacenar el objeto recogido

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 50.0f, Color.red);
        CheckForPickup();
    }
    
    private void CheckForPickup()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 20.0f))
        {
            if (Input.GetKeyDown(KeyCode.F)) // Cambiado a GetKeyDown para recoger
            {
                if (hit.transform.gameObject.TryGetComponent<Pickupable>(out Pickupable pickupable))
                {
                    SetPickupState(pickupable);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.G)) // Cambiado a GetKeyDown para soltar
        {
            DropItem();
        }
    }

    private void SetPickupState(Pickupable pickupable)
    {
        if (currentPickupable == null) // Solo recoger si no se tiene uno
        {
            currentPickupable = pickupable;
            currentPickupable.SetPickedState(holdPosition);
        }
    }

    private void DropItem()
    {
        if (currentPickupable != null) // Solo soltar si hay algo
        {
            currentPickupable.SetDroppedState();
            currentPickupable = null; // Reiniciar el objeto actual
        }
    }
}
