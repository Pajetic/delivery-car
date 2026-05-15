using System;
using UnityEngine;

public class DeliveryHandler : MonoBehaviour
{
    private bool hasPackage;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pickup") && !hasPackage)
        {
            hasPackage = true;
            Destroy(other.gameObject);
            GetComponent<ParticleSystem>().Play();
            Debug.Log("Item pickup");
        }

        if (other.CompareTag("Customer") && hasPackage)
        {
            hasPackage = false;
            Destroy(other.gameObject);
            Debug.Log("Item delivered");
            GetComponent<ParticleSystem>().Stop();
        }
    }
}
