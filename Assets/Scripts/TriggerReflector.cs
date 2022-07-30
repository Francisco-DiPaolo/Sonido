using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerReflector : MonoBehaviour
{
    public GameObject reflector;

    private void Start()
    {
        reflector.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TriggerReflector"))
        {
            reflector.SetActive(true);
        }
    }
}