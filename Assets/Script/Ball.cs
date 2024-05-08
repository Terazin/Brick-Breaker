using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 100;
    Rigidbody rb;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 force = new Vector3(1.0f, 1.0f, 0.0f) * speed;
        // —Í‚ð‰Á‚¦‚é
        rb.AddForce(force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
