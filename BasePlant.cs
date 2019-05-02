using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasePlant : MonoBehaviour {
    float growTime = 0f;
    float matureTime = 5f;
    string name = "noName";
    public Text nameText;
    public Text stateText;
    private bool mature = false;
    public Master ms;
    public GameObject m;
    private void Start()
    {
        m=GameObject.Find("Master");
        ms =m.GetComponent<Master>(); 
    }
    void Update () {
       
        growTime = growTime + (1 * Time.deltaTime);
        if (growTime > matureTime) {
            stateText.text = "mature";
            mature = true;
        }
        else { stateText.text = "seedling"; }
	}
    public void Gather() {
        if (mature == true) {
            ms.numOfPlants++;
            Destroy(this.gameObject);
        }
    }
}
