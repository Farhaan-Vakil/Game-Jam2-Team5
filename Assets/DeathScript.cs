using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    public Vector2 respawn;

    private int maxCheckpoint = 0;
    
    void Start()
    {
        respawn = transform.position;
    }

    public void Respawn()
    {
        GetComponent<Energy>().refillEnergy();
        gameObject.transform.position = respawn;
        
        Debug.Log(GameObject.FindGameObjectsWithTag("Key").Length);
        
        foreach(GameObject key in GameObject.FindGameObjectsWithTag("Key")) {
            key.GetComponent<Key>().resetKey(maxCheckpoint);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Death")
        {
            Respawn();
        }
    }

    public void setRespawn(int checkpointNum, Vector2 location){
        if (checkpointNum > maxCheckpoint){
            maxCheckpoint = checkpointNum;
            respawn = location;
        }
    }
}
