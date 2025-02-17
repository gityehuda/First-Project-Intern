using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField] private Snapping snap;
    public GameObject[] parts;
    public bool isBodyPlaced = false;


    void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(snap.isPlaced == true) 
        {
           isBodyPlaced = true;
        }
        else
        {
            /* for (int i = 0; i < parts.Length; i++) 
             {
                 if (parts[i].GetComponent<Identity>().identityName != "Body")
                 {
                     parts[i].GetComponent<Snapping>().enabled = true;
                 }
             }*/
            return;
        }
    }

    public static GameManager GetInstance()
    {
        return instance;
    }

}
