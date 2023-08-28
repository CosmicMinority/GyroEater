using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    public Rigidbody Rb;
    public float Speed;
    public float Lift;
    public float maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Rb.AddForce(transform.forward * Speed, ForceMode.Acceleration);


        Rb.AddForce(transform.up * Lift, ForceMode.Acceleration);



        Rb.velocity = Vector3.ClampMagnitude(Rb.velocity, maxSpeed);
    }
}
