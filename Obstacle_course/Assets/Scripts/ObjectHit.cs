using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player") // It's the way how we access particular tag
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit"; // to change the tag of the object that was hitted by player.

        }
        //Debug.Log("Bumped into a wall");
    }
}
