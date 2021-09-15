using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Item
{
      string _name;



    public void onRightClick() { }
}

public class Stick : Item
{

    public Stick() : base()
    {
        
    }

    public void onRightClick()
    {
       
    }
}

public class ItemStack {

    public Item item;
    public int count;
    public ItemStack(int count, Item item)
    {
        this.item = item;
        this.count = count;
    }

}
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Stick stick = new Stick();
    }
    public static ItemStack[] Invetory;
    // Update is called once per frame
    void Update()
    {
        
    }
}
