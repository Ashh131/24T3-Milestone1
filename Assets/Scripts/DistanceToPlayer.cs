using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToPlayer : MonoBehaviour
{
   public Transform Player;
   public float detectionDistance = 5.0f;



    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance (transform.position, Player.position);
        if (distanceToPlayer <= detectionDistance)
        {
            Debug.Log("Player is close enough");
        }
    }
}
