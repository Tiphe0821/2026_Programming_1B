using System.Numerics;
using UnityEngine;

public class L2_Monster : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += UnityEngine.Vector3.forward * 0.03f;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += UnityEngine.Vector3.left * 0.03f;
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position += UnityEngine.Vector3.back * 0.03f;
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.position += UnityEngine.Vector3.right * 0.03f;
        }
    }
}
