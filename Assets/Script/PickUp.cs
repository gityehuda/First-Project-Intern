using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public LayerMask carPartLayer;
    public Transform holdPosition;
    public GameObject heldPart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (heldPart == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 10f))
                {
                    if (hit.transform.gameObject.tag == "PickUp" || hit.transform.gameObject.tag == "CarBody")
                    {
                        PickUpObject(hit.transform.gameObject);
                    }
                }
            }
        }
        /* if (heldPart != null && Vector3.Distance(heldPart.transform.position, snapPoint.position) < snapRange) 
        {
            SnapPart();
        }*/
    }
    void PickUpObject(GameObject part)
    {
        if (heldPart == null) 
        {
           heldPart = part;
           part.GetComponent<Rigidbody>().isKinematic = true;
           part.transform.position = holdPosition.position;
           part.transform.SetParent(holdPosition);
        }
    }

    public Transform snapPoint;
    public float snapRange = 0.5f;

    /*  void SnapPart()
    {
        heldPart.transform.position = snapPoint.position;
        //heldPart.transform.rotation = snapPoint.rotation;
        heldPart.GetComponent<Rigidbody>().isKinematic = true;
        heldPart.transform.SetParent(snapPoint);
        heldPart = null;
    }*/

}
