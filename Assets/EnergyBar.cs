using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.UI;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour{

    private Image thisImage;
    // Start is called before the first frame update
    void Start(){
        thisImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void updateBar(double energy, double total){
        thisImage.fillAmount = (float) (energy / total);
    }
}
