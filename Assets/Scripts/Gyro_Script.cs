using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Gyro_Script : MonoBehaviour
{
    Vector3 Rotation;
    public float RotSpeed;
    public Animator Animator;
    Vector3 RotAxis;

    // Start is called before the first frame update
    void Start()
    {

        
        Rotation = Vector3.zero;  
        Input.gyro.enabled=true;
    }

    // Update is called once per frame
    void Update()
    {
       // Rotation = - Input.gyro.rotationRateUnbiased;
       
        Rotation = new Vector3(-Input.gyro.rotationRateUnbiased.x,- Input.gyro.rotationRateUnbiased.y,Input.gyro.rotationRateUnbiased.z);
       // transform.rotation = - Input.gyro.attitude;
        transform.Rotate(Rotation*RotSpeed*Time.deltaTime);
        
        
       
        Animator.SetFloat("Input direction",transform.rotation.x);
    }
}
