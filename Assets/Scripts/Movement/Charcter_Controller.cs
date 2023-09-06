using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_Controller : MonoBehaviour
{
    public Rigidbody Rb;
    public float Speed;
    //public float Lift;
    public float maxSpeed;
    Vector3 movementDirection;
    public Transform Area;
    public GameObject Bullet;

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

       // Rb.AddForce(transform.forward * Speed, ForceMode.Acceleration);
        Rb.AddRelativeForce(Vector3.forward* Speed, ForceMode.Acceleration);

        //Rb.AddRelativeForce(Vector3.up* Lift, ForceMode.Acceleration);



       Rb.velocity = Vector3.ClampMagnitude(Rb.velocity, maxSpeed);
    }
    public void SHoot()
    {
        Debug.Log("Button");
        Instantiate(Bullet, Area.position, Quaternion.identity);
    }

}
