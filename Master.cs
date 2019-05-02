using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Master : MonoBehaviour {
    public GameObject pot,pot2,pot3;
    public GameObject plant;
    public bool potFull, pot2Full, pot3Full;
    public Text text;
    public Transform potLocation, pot2Location, pot3Location;
    public int numOfPlants = 0;
    private Pot ps,ps2,ps3;
    private void Start()
    {
    potFull = false;
    pot2Full = false;
    pot3Full = false;
    ps = pot.GetComponent<Pot>();
    ps2 = pot2.GetComponent<Pot>();
    ps3 = pot3.GetComponent<Pot>();
    }
    public void Plant(string pot) {
        text.text = "added to "+ pot;
        if (pot=="pot") {
            Instantiate(plant,potLocation);
            ps.clean = false;
        }
        if (pot == "pot 2")
        {
            Instantiate(plant, pot2Location);
            ps2.clean = false;
        }
        else if(pot == "pot 3")
        {
            Instantiate(plant, pot3Location);
            ps3.clean = false;
        }
    }
    public void AddToPot(){
        if (potFull == false){
            potFull = true;
            Plant("pot");
        }
        else {
            if (pot2Full == false)
            {
                pot2Full = true;
                Plant("pot 2");
            }
            else
            {
                if (pot3Full == false)
                {
                    pot3Full = true;
                    Plant("pot 3");
                }
                else
                {
                    text.text = "all pots are full";
                }
            }
        }
    }
    public void Clean() {
        if (ps.clean == true) {
            potFull = false;
        }
        if (ps2.clean == true)
        {
            pot2Full = false;
        }
        else if (ps3.clean == true)
        {
            pot3Full = false;
        }
    }
}
