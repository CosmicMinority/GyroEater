using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavefilter : MonoBehaviour
{
    public GameObject Waterfilter;
    public static event Action startEnemyFollow;
    public static event Action stopEnemyFollow;
    public const string player = "Player";

    // Start is called before the first frame update
    void Start()
    {
        Waterfilter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(player))
        { 

            Waterfilter.SetActive(true);
        startEnemyFollow?.Invoke();

        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(player))
        {
            Waterfilter.SetActive(false);
            stopEnemyFollow?.Invoke();

        }
        
    }
}
