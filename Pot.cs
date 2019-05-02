using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pot : MonoBehaviour {
    public Text name;
    public Text state;
    public bool clean = true;
    private Master ms;
    public GameObject m;
    public void Start()
    {
        name.text = "";
        state.text = "empty pot";
        m = GameObject.Find("Master");
        ms = m.GetComponent<Master>();
    }
    public void Clean() {
           clean = true;
           ms.Clean();
    }
    public void Upgrade() {
    }
}
