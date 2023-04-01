using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnergyText : MonoBehaviour{

    private TMP_Text textObj;
    
    // Start is called before the first frame update
    void Start(){
        textObj = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateEnergyText(double energy, double total){
        textObj.text = (int)energy + "/" + (int)total;
    }
}
