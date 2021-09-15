using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : Inventory
{
    public float radius = 1f;
    public LayerMask Mask;
    bool isNear;


    public ItemStack item = new ItemStack();
    // Update is called once per frame
    /*
     * void Update()
    {
        isNear = Physics.CheckSphere(transform.position, radius, Mask);
        if (isNear && Input.GetButtonDown("Interact"))
        {
            

        }
    }
     * */



}
