using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfollow : MonoBehaviour
{
    public Transform Player;
    Rigidbody rb;
    public float enemyspeed;
    public bool attackPlayer;
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

        rb = GetComponent<Rigidbody>();

    }

    
    void Update()
    {
      if(attackPlayer)
         {
           transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, enemyspeed * Time.deltaTime);
           transform.LookAt(Player.transform.position);
        }

    }

    void StartChasing()
    {
        attackPlayer = true;
    }

    void StopChasing()
    {
        attackPlayer= false;
    }


}