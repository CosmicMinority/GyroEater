using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavefilter : MonoBehaviour
{
    public GameObject Waterfilter;
    public static event Action startEnemyFollow;
    public static event Action stopEnemyFollow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Waterfilter.SetActive(true);
        startEnemyFollow?.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        Waterfilter.SetActive(false);
        stopEnemyFollow?.Invoke();
    }
}
