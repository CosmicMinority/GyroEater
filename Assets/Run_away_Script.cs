using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run_away_Script : MonoBehaviour
{
    public Transform Player;
    public Rigidbody FshRB;
    public float Fishspeed;
    public bool attackPlayer;
    //public Animator fish;
    private const string PlayerStr = "Player";
    
    // Start is called before the first frame update
    private void Awake()
    {
        Wavefilter.startEnemyFollow += StartChasing;
        Wavefilter.stopEnemyFollow += StopChasing;
    }

    private void OnDisable()
    {
        Wavefilter.startEnemyFollow -= StartChasing;
        Wavefilter.stopEnemyFollow -= StopChasing;

    }
    void Start()
    {

    

    }


    void Update()
    {

       
        if (attackPlayer)
        {
            transform.LookAt(Player);
            transform.Rotate(0, 180, 0);
            FshRB.AddRelativeForce(Vector3.forward * Fishspeed, ForceMode.Acceleration);
        }

    }

    void StartChasing()
    {
       // fish.SetBool("Chase", true);
        attackPlayer = true;
    }

    void StopChasing()
    {
        //fish.SetBool("Chase", false);
        attackPlayer = false;
    }
}
