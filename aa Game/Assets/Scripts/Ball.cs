using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    /*[SerializeField] private Transform BallPointTransform;
    [SerializeField] private Transform FixedBallPointTransform;
    [SerializeField] private Transform BallTransform;
    [SerializeField] private GameObject BallPrefab;
    [SerializeField] private GameObject FixedBallPrefab;*/
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

    /*void DistanceController()
    {
        float range = Vector2.Distance(BallTransform.position, FixedBallPointTransform.position);

        if (range < 0.1f)
        {
            Instantiate(FixedBallPrefab, FixedBallPointTransform.position, FixedBallPointTransform.rotation);
            Destroy(BallPrefab);
        }
    }*/
}