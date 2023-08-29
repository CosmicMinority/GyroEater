using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavefilter : MonoBehaviour
{
    public GameObject Waterfilter;

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

    }
    private void OnTriggerExit(Collider other)
    {
        Waterfilter.SetActive(false);
    }
}
