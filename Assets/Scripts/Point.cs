using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public float speed = 30;
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(1, 2, 3) * Time.deltaTime * speed);    
    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
}
