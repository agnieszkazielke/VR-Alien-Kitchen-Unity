using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public GameObject servingDish;
    public GameObject servingArea;
    public Canvas taskDone;
   // public bool startersCheck;
   // public bool servingAreaCheck;
    public bool dishServed;


    public string sceneName;
    public string sceneName_1 = "VR Kitchen_Scene_1_Starters";
    public string sceneName_2 = "VR Kitchen_Scene_2_Sandwiches";
    public string sceneName_3 = "VR Kitchen_Scene_3_Soup";

    // Start is called before the first frame update
    void Awake()
    {
        sceneName = SceneManager.GetActiveScene().name;
        // startersCheck = servingPlate.GetComponent<StartersCheck>().plateLoaded;
        // servingAreaCheck = servingArea.GetComponent<ServingCheck>().plateServed;
    }

 

    // Update is called once per frame
    void Update()
    {

        if (sceneName == sceneName_1)
        {
            if (servingDish.GetComponent<ServingPlate>().plateLoaded == true && servingArea.GetComponent<ServingCheck>().plateServed == true)
            {
                Debug.Log("TASK DONE");
                dishServed = true;
                taskDone.gameObject.SetActive(true);

            }

            else
            {
                dishServed = false;
            }
        }


        if (sceneName == sceneName_2)
        {
            if (servingDish.GetComponent<ServingPlate>().plateLoaded == true && servingArea.GetComponent<ServingCheck>().plateServed == true)
            {
                Debug.Log("TASK DONE");
                dishServed = true;
                taskDone.gameObject.SetActive(true);

            }

            else
            {
                dishServed = false;
            }
        }



        if (sceneName == sceneName_3)
        {
            if (servingDish.GetComponent<ServingBowl>().soupServed == true && servingArea.GetComponent<ServingCheck>().plateServed == true)
            {
                Debug.Log("TASK DONE");
                dishServed = true;
                taskDone.gameObject.SetActive(true);

            }
        }







    }


}
