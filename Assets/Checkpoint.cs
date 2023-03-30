using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour{
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
        if (other.CompareTag("Player")){
            Debug.Log("Checkpoint reached");
            renderer.color = Color.blue;
            death.respawn = transform.position;
            GameObject.Find("Player").GetComponent<Energy>().energy = 11;
        }
    }
}
