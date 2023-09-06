using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Gyro_Script : MonoBehaviour
{
    Vector3 Rotation;
    public float RotSpeed;
    public Animator Animator;
    Vector3 RotAxis;
    public Transform player;
    public int TurnA;
    private bool Turnright = false;
    private bool Turnup = false;
    private bool Turnleft = false;

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
        
        
       
        Animator.SetFloat("Input direction",player.rotation.eulerAngles.x);
       
        //Changing Turn Speed

        if (Turnright == true)
        {
            transform.Rotate(0, TurnA + Time.deltaTime, 0);
        }
        if (Turnup == true)
        {
            transform.Rotate(-TurnA - Time.deltaTime, 0, 0);
        }
        if (Turnleft == true)
        {
            transform.Rotate(0, -TurnA - Time.deltaTime, 0);
        }
    }
    public void Rightside(bool _Turnright)
    {
        Turnright = _Turnright;

    }
    public void Leftside(bool _Turnleft)
    {
       
        Turnleft = _Turnleft;

    }
    public void Upside(bool _Turnup)
    {
        Turnup = _Turnup;
    }
}
