using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour{

    public GameObject player;

    public double camAccel = 0.1;
    public double maxXError = 0.5;
    public double maxYError = 0.5;
    public double followRatio = 0.5;

    public double camBoundLeft = -0.5;
    public double camBoundRight = 15;
    public double camBoundUp = 10;
    public double camBoundDown = -2;

    private double distX, distY;
    private Vector2 playerPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        playerPosition = player.transform.position;
        distX = playerPosition.x - transform.position.x;
        distY = playerPosition.y - transform.position.y;
    }

    private void FixedUpdate(){
        if (distX > maxXError || -distX > maxXError){
            transform.Translate(Vector2.right * ((float)distX * (float)followRatio));
        }

        if (distY > maxYError || -distY > maxYError){
            transform.Translate(Vector2.up * ((float)distY * (float)followRatio));
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, (float) camBoundLeft, (float) camBoundRight),
                                           Mathf.Clamp(transform.position.y, (float) camBoundDown, (float) camBoundUp),
                                            -15);
    }
}
