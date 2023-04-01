using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour{

    public int checkPointNumber;

    private bool activated = false;
    
    private SpriteRenderer renderer;
    private DeathScript death;

    // Start is called before the first frame update
    void Start(){
        renderer = GetComponent<SpriteRenderer>();
        death = GameObject.Find("Player").GetComponent<DeathScript>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){

        if (activated) return;
        
        if (other.CompareTag("Player")){
            Debug.Log("Checkpoint reached");
            renderer.color = Color.blue;
            death.setRespawn(checkPointNumber, transform.position);
            GameObject.FindWithTag("Player").GetComponent<Energy>().refillEnergy();
        }

        activated = true;
    }
}
