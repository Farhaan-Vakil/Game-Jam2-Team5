using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour{

    public int energy;
    private double timeElapsed;
    public double interval;
    public GameObject EnergyUI;
    private UpdateEnergy updateScript;
    private DeathScript death;

    // Start is called before the first frame update
    void Start(){
        updateScript = EnergyUI.GetComponent<UpdateEnergy>();
        updateScript.updateEnergy(energy);
    }

    // Update is called once per frame
    void Update(){
        timeElapsed += Time.deltaTime;
        if (timeElapsed > interval){
            timeElapsed -= interval;
            energy--;
            if (energy <= 0)
            {
                energy = 0;
                death.Respawn();
            }
            updateScript.updateEnergy(energy);
        }
    }
}
