using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit") // �]��Scorer��script�O�˦bplayer�W�A�Gcollision.gameObject.tag�|�O�Pplayer�I��object��tag�A�������N�Owall or obstacle.
        {
            if(collision.gameObject.tag != "Plane")
            {
                hits++;
                Debug.Log("You've bumped into a thing this many times:" + hits); // Execute when collision occur.
            }
        }
    }
}
