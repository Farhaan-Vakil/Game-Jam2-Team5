using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    public Vector2 respawn;

    void Start()
    {
        respawn = transform.position;
    }

    public void Respawn()
    {
        GameObject.Find("Player").GetComponent<Energy>().energy = 11;
        gameObject.transform.position = respawn;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Death")
        {
            Respawn();
        }
    }
}
