using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit") // 因為Scorer的script是裝在player上，故collision.gameObject.tag會是與player碰撞object的tag，換言之就是wall or obstacle.
        {
            if(collision.gameObject.tag != "Plane")
            {
                hits++;
                Debug.Log("You've bumped into a thing this many times:" + hits); // Execute when collision occur.
            }
        }
    }
}
