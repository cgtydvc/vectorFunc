using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayscript : MonoBehaviour
{

    int layerMask = (1<<10) | (1<<9);
    
    private void Update()
    {
        int LayerMask = ~layerMask;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up),out hit,Mathf.Infinity,layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * hit.distance,Color.red);
            Debug.Log("hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up), Color.yellow, 1000f);
            Debug.LogError("missed");
        }
    }
}
