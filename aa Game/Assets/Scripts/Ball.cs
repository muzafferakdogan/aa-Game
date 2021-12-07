using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Transform BallPoint;
    [SerializeField] private Transform FixedBallPoint;
    [SerializeField] private Transform Balls;
    [SerializeField] private GameObject BallPrefab;
    [SerializeField] private GameObject FixedBallPrefab;
    private Vector2 ball;
    private Vector2 targetPosition;
    private float range;

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            CreatBall();
        }
    }

    void CreatBall()
    {
        Instantiate(BallPrefab, BallPoint.position, BallPoint.rotation);
    }

    void DistanceController()
    {
        float range = Vector2.Distance(Balls.position, FixedBallPoint.position);

        if (range < 0.1f)
        {
            Instantiate(FixedBallPrefab, FixedBallPoint.position, FixedBallPoint.rotation);
            Destroy(BallPrefab);
        }
    }

    void RotateBall()
    {

    }
}
