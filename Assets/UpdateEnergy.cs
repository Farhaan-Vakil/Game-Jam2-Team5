using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateEnergy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateEnergy(int newEnergy){
        GetComponent<TMP_Text>().text = "Energy: " + newEnergy;
    }
}
