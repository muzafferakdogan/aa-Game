using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    [SerializeField] private Transform BallPointTransform;
    [SerializeField] private Transform FixedBallPointTransform;
    [SerializeField] private Transform BallTransform;
    [SerializeField] private GameObject BallPrefab;
    [SerializeField] private GameObject FixedBallPrefab;
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
        Instantiate(BallPrefab, BallPointTransform.position, BallPointTransform.rotation);
        Debug.Log(BallPointTransform.position);
    }

    void DistanceController()
    {
        float range = Vector2.Distance(FixedBallPointTransform.position, BallTransform.localPosition);
        Debug.Log(range);
        Debug.Log(BallPointTransform.position);
        if (range < 0.1f)
        {
            Instantiate(FixedBallPrefab, FixedBallPointTransform.position, FixedBallPointTransform.rotation);
            Destroy(BallPrefab);
        }
    }
}