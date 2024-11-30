using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    GameObject player;
    Rigidbody2D playerRB;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        playerRB = player.GetComponent<Rigidbody2D>();
    }
    
    void LateUpdate()
    {
        Vector3 pos = transform.position;
        pos.x = playerRB.position.x;
        pos.y = playerRB.position.y;
        transform.position = pos;
    }
}
