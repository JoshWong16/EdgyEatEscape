﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameObject.transform.position != player.transform.position)) {

             gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + -10);

        }
    }
}
