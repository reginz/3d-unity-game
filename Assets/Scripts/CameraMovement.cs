﻿
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    void FixedUpdate()
    {
        transform.position = player.position + offset;

    }
}
