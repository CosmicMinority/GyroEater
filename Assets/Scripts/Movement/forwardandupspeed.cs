using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forwardandupspeed : MonoBehaviour
{
    public float speed;
    public float lift;
    public float maxSpeed;

    public Rigidbody rb;

    public GameObject ship;

 


   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

       

        Quaternion Devicerotation = DeviceRotation.Get();

        transform.rotation  = Devicerotation;

        rb.AddForce(transform.forward * speed, ForceMode.Acceleration);


        rb.AddForce(transform.up * lift , ForceMode.Acceleration);

       

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        
    }
}
