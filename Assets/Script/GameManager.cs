using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Snapping snap;
    public GameObject[] parts; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(snap.isPlaced == false) 
        {
            for(int i = 0;  i < parts.Length; i++)
            {
                if(parts[i].GetComponent<Identity>().identityName != "Body")
                {
                   parts[i].GetComponent<Snapping>().enabled = false;
                }
            
            }
        }
        else
        {
            return;
        }
    }
}
