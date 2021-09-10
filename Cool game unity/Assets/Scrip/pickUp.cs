using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public float radius = 1f;
    public LayerMask Mask;
    bool isNear;

    public item item;
    // Update is called once per frame
    void Update()
    {
        isNear = Physics.CheckSphere(transform.position, radius, Mask);
        if (isNear && Input.GetButtonDown("Interact"))
        {
            pickUpObject();
        }
    }

    public void pickUpObject()
    {
        Debug.Log("Picking up " + item.name);
        Destroy(gameObject);
               
    }
}
