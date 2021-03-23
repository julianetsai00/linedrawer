﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
// This script requires the GameObject to have a Rigidbody2D component
// [RequireComponent(typeof(Rigidbody2D))]
public class pingpong : MonoBehaviour
{
/// <summary>The objects initial position.</summary>
private Vector2 startPosition;
/// <summary>The objects updated position for the next frame.</summary>
private Vector2 newPosition;

/// <summary>The speed at which the object moves.</summary>
[SerializeField] private int speed = 3;
/// <summary>The maximum distance the object may move in either y direction.</summary>
[SerializeField] private int maxDistance = 1;

void Start()
{   Time.timeScale=1;
    startPosition = transform.position;
    newPosition = transform.position;
}

void Update()
{
    newPosition.x = startPosition.x + (maxDistance * Mathf.Sin(Time.time * speed));
    transform.position = newPosition;
}
}