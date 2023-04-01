using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour{

    public int checkpoint;
    
    private List<GameObject> children;
    
    // Start is called before the first frame update
    void Start(){
        children = new List<GameObject>();
        foreach (Transform childTransform in GetComponentsInChildren<Transform>()){
            children.Add(childTransform.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
            Debug.Log("Key collected");
            GetComponent<Renderer>().enabled = false;
            setWallActive(false);
        }
    }

    private void setWallActive(bool active){
        for (int i = 0; i < children.Count; i++){
            if(!children[i].tag.Equals("Key")) children[i].SetActive(active);
        }
    }

    public void resetKey(int respawnCheckpoint){
        if (respawnCheckpoint < checkpoint){
            setWallActive(true);
            GetComponent<Renderer>().enabled = true;
        }
    }
}
