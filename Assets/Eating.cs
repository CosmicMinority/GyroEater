using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : MonoBehaviour
{
    private const string fishStr = "Fish";
    public GameObject eatingFX;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(fishStr))
        {
            Destroy(other.gameObject);
            Instantiate(eatingFX, transform.position, Quaternion.identity);
        }
    }
}
