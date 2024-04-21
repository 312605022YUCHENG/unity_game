using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBody; // 用來定義變數類型，類型需要存在於Unity建構環境。
    [SerializeField] float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        
        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait)
        {
            // Debug.Log("3 seconds has elapsed.");
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
