using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderCollisions : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision detected");
        gameObject.GetComponent<Animator>().SetTrigger("attack");
        
        //other.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered");
    }
}
