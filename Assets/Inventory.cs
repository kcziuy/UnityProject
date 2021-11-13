using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Vector2Int Size;

    private InventoryItem[,] items;

    // Start is called before the first frame update
    void Start()
    {
        items = new InventoryItem[Size.x, Size.y];
    }

    public void PickObject()
    { 
        
    }

    public void DeleteObject()
    {
    
    }
}

public class InventoryItem
{


}