using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject servingPlate;
    public GameObject servingArea;
    public Canvas taskDone;
   // public bool startersCheck;
   // public bool servingAreaCheck;
    public bool startersDone;


    // Start is called before the first frame update
    void Start()
    {
        // startersCheck = servingPlate.GetComponent<StartersCheck>().plateLoaded;
        // servingAreaCheck = servingArea.GetComponent<ServingCheck>().plateServed;
    }

 

    // Update is called once per frame
    void Update()
    {
        if (servingPlate.GetComponent<StartersCheck>().plateLoaded == true && servingArea.GetComponent<ServingCheck>().plateServed == true)
        {
            Debug.Log("TASK DONE MATE");
            startersDone = true;
            taskDone.gameObject.SetActive(true);
            
        }

        else
        {
            startersDone = false;
        }

    }
}
