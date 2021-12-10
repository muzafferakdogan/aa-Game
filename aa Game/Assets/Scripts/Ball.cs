using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float BallSpeed;

    private void Start()
    {

    }

    void Update()
    {
        MoveBall();
    }

    void MoveBall()
    {
        transform.position += transform.up * BallSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("carpti");
    }
}