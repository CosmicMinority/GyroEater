using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmovement : MonoBehaviour
{
    public float Bulspeed;
    public Rigidbody Bul;
    //public Transform ShootinArea;
    private const string Shoot= "Shooting" ;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
      Vector3 direction =  player.transform.position - transform.position;
        Bul.velocity =new Vector3(direction.x, direction.y, direction.z).normalized * Bulspeed;
    }

    // Update is called once per frame
    void Update()
    {
      

    }
}
