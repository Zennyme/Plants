using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour {
    public Master m;
    void press(){
        m.AddToPot();
    }
}
