using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Looking_scrpt : MonoBehaviour
{
    public Transform player;
    public float attackrange;
    public float attackDelay;
    public GameObject bullet;
    public Transform shootarea;
    public float Bulspeed;
    public float attackintervals;

    // Start is called before the first frame update
    void Start()
    {
        
        bullet.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        attackintervals += Time.deltaTime;

        transform.LookAt(player);

        if (Vector3.Distance(player.position, transform.position) < attackrange && attackDelay < attackintervals)
        { 
            attackintervals = 0f;
            shoot();
        }
        /*if (Vector3.Distance(shootarea.position, transform.position) < attackrange!)
        {
            Debug.Log("Check");
            
        }*/
       
    }
    /*private void attack()
    {
        
        yield return new WaitForSeconds(attackDelay);
       

       
    } */
    void shoot()
    {

        Debug.Log("I hate this alot");
        Instantiate(bullet, shootarea.position, shootarea.rotation);

    }
}
