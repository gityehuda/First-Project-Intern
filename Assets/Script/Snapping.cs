using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snapping : MonoBehaviour
{
    public Transform snapPoint;
    public float snapRange = 2f;
    private Animator animator;
    public bool isPlaced = false;
    public bool isBodyPlaced = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, snapPoint.position) < snapRange)
        {
            if(GetComponent<Identity>().identityName != "Body" && GameManager.GetInstance().isBodyPlaced == true)
            {
                isPlaced = true;
                SnapToPosition();

            }
            else if(GetComponent<Identity>().identityName == "Body")
            {
                isPlaced = true;
                SnapToPosition();
            }
          
        }
        else 
        {
            GetComponent<Rigidbody>().isKinematic = false;
            isPlaced = false;
        }
    }

   /* private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SnapPoint")
        {
            SnapToPosition();
        }
    }*/

    public void SnapToPosition()
    {
       
        if (GetComponent<Identity>().identityName == "Body")
        {
            transform.position = snapPoint.position;
            transform.rotation = Quaternion.Euler(90f, 0, 0);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Front")
        {
            transform.position = snapPoint.position + new Vector3(-1f, 0.3f, -2.9f);
            transform.rotation = Quaternion.Euler(90f, 0, 180f);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Side")
        {
            transform.position = snapPoint.position + new Vector3(0.1f, 0.4f, 0);
            transform.rotation = Quaternion.Euler(90f, 0, 0);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Side Mirror")
        {
            transform.position = snapPoint.position + new Vector3(-1.2f, 0, 1f);
            transform.rotation = Quaternion.Euler(-90f, 0, 0);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Bumper")
        {
            transform.position = snapPoint.position + new Vector3(0, 0.5f, -3.6f);
            transform.rotation = Quaternion.Euler (90f, 0, 0);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Front Window")
        {
            transform.position = snapPoint.position + new Vector3(0.1f, 0.65f, 0.13f);
            transform.rotation = Quaternion.Euler(-90f, -180f, 90f);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Roof")
        {
            transform.position = snapPoint.position + new Vector3(0.1f, 0.67f, -0.6f);
            transform.rotation = Quaternion.Euler(-90f, 90f, 180f);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Right Window")
        {
            transform.position = snapPoint.position + new Vector3(1f, 0.65f, -1f);
            transform.rotation = Quaternion.Euler(20f, 270f, 0);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Left Window")
        {
            transform.position = snapPoint.position + new Vector3(-0.8f, 0.65f, -1f);
            transform.rotation = Quaternion.Euler(-20f, 270f, 180f);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Rear Window")
        {
            transform.position = snapPoint.position + new Vector3(0, 0.5f, 1.1f);
            transform.rotation = Quaternion.Euler(-90f, 0, 0);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Front Right Tyre")
        {
            transform.position = snapPoint.position + new Vector3(1.2f, -0.2f, 1.9f);
            transform.rotation = Quaternion.Euler(0, 90f, 0);
            GetComponent<Rigidbody>().isKinematic = true;
        }
        
        if(GetComponent<Identity>().identityName == "Front Left Tyre")
        {
            transform.position = snapPoint.position + new Vector3(-1.2f, -0.2f, 1.8f);
            transform.rotation = Quaternion.Euler(0, 90f, 0);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Rear Right Tyre")
        {
            transform.position = snapPoint.position + new Vector3(1.1f, -0.2f, 1.2f);
            transform.rotation = Quaternion.Euler(0, 90f, 0);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Rear Left Tyre")
        {
            transform.position = snapPoint.position + new Vector3(-1.3f, -0.2f, 1.2f);
            transform.rotation = Quaternion.Euler(0, 90f, 0);
            GetComponent<Rigidbody>().isKinematic = true;
        }

        if(GetComponent<Identity>().identityName == "Back Light")
        {
            transform.position = snapPoint.position + new Vector3(0.2f, -0.2f, -1.07f);
            transform.rotation = Quaternion.Euler(-90f, 0, 0);
            GetComponent<Rigidbody>().isKinematic = true;   
        }
    }
}
