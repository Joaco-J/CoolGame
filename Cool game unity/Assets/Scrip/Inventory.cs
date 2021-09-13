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

    public item[] inventory = new item[9];
    int[] nunInvetory = new int[9];
    public Text pp;


    void FreeSpace()
    {
        for (int x = 0; x < 9; x++)
        {
            if (null == inventory[x])
            {
                return int x;
                break;
            }

        }
    }
    void AddToIn(item Item)
    {
        for(int x=0; x < 9; x++)
        {
            if (Item == inventory[x])
            {
                nunInvetory[x] += 1;
            }

        }

    }
    
    public void pickUpObject(item a)
    {
        Debug.Log("Picking up " + a.name);
        Destroy(gameObject);

    }
    
}
