using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    #region Singleton
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found!");
            return;
        }
        instance = this;
    }
    #endregion

    public static item[] inventory = new item[9];
    public int[] numInventory = new int[9];
    public Text pp;
    bool In;


    public void AddToIn(item Item)
    {
        In = false;
        for(int x=0; x < 9; x++)
        {
            if (Item == inventory[x])
            {
                numInventory[x] += 1;
                In = true;
            }

        }
        if (In == false)
        {
            for (int x = 0; x < 9; x++)
            {
                if (null == inventory[x])
                {
                    inventory[x] = Item;
                    numInventory[x] = 1;
                    In = true;
                    break;
                }

            }
        }
        else
        {
            In = false;
        }

        
    }
    
    public void pickUpObject(item a)
    {
        Debug.Log("Picking up " + a.name);
        AddToIn(a);
        Destroy(gameObject);

    }

    public void display(Text pp)
    {
        for (int x = 0; x < 9; x++)
        {
            pp.text = "ars";
                //inventory[x].name.ToString() + numInventory[x].ToString() + " ,";
        }
    }


    void Update()
    {
        display(pp);
        for (int x = 0; x < 9; x++)
        {
            Debug.Log(inventory[x]);
        }
    }

}
