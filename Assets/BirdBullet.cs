using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBullet : MonoBehaviour
{
    public float Bulspeed;
    public Rigidbody Bul;
    //public Transform ShootinArea;
    private const string Shoot = "Shooting";
    private GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag("shooting point");
        Vector3 direction = Enemy.transform.position - transform.position;
        Bul.velocity = new Vector3(direction.x, direction.y, direction.z).normalized * Bulspeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
