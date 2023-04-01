using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Energy : MonoBehaviour{

    public double startEnergy = 100;
    private double energy;
    public double rate;

    public GameObject energyBarObj;
    private EnergyBar energyBarScript;

    public GameObject EnergyTextObj;
    private EnergyText energyTextScript;

    private DeathScript death;

    // Start is called before the first frame update
    void Start(){
        energyBarScript = energyBarObj.GetComponent<EnergyBar>();
        energyTextScript = EnergyTextObj.GetComponent<EnergyText>();
        death = GetComponent<DeathScript>();
        energy = startEnergy;
    }

    // Update is called once per frame
    void Update(){
        energy -= rate * Time.deltaTime;
        energyBarScript.updateBar(energy, startEnergy);
        energyTextScript.updateEnergyText(energy, startEnergy);
        if (energy <= 0){
            death.Respawn();
        }
    }

    public void refillEnergy(){
        energy = startEnergy;
    }
}
