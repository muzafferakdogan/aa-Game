using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedBall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
    }
}
