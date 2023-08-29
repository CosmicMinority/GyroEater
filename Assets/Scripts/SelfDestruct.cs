using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField] float destructionTime;
  
    void Start()
    {
        Destroy(gameObject, destructionTime);
    }

   
}
