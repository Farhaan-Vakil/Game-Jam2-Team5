using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsButton : MonoBehaviour{

    public GameObject instructionsText;
    private bool active = false;
    
    // Start is called before the first frame update
    void Start()
    {
        instructionsText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clicked(){
        active ^= true;
        instructionsText.SetActive(active);
    }
}
