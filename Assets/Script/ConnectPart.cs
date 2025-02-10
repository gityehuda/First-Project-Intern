using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectPart : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CarPart"))
        {
            other.transform.SetParent(transform);
            other.transform.position = new Vector3(0.005f, 0.014f, -0.005f);
            other.transform.rotation = Quaternion.Euler(-180f, 0, 0);
        }
    }

}
