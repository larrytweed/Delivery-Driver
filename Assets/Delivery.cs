using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 1f;
    bool hasPackage;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            Debug.Log("Package picked up");
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            Debug.Log("Package Delivered");
        }

    }


}
