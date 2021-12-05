using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class ServingPlate : MonoBehaviour
{
    
    // Starters params
    
    public bool olivesIn;
    public bool breadsticksIn;
    public bool hummusIn;

    public GameObject socketHummus;
    public GameObject socketBreadstick;
    public GameObject socketOlives;

    // Sandwiches params


    public bool sandwichIn;
    public GameObject socketSandwich;
    public GameObject sandwichToCheck;

  

    // Universal params

    public GameManager gameManager;
    public XRSocketInteractor socketInteractor;
    public bool plateLoaded;




    // Starters Functions

    public void SetOlivesOn()
    {
        olivesIn = true;
    }

    public void SetHummusOn()
    {
        hummusIn = true;
    }

    public void SetBreadSticksOn()
    {
        breadsticksIn = true;
    }

    public void SetOlivesOff()
    {
        olivesIn = false;
    }

    public void SetHummusOff()
    {
        hummusIn = false;
    }

    public void SetBreadSticksOff()
    {
        breadsticksIn = false;
    }


    // Sandwiches Functions


 

    public void SetSandwichOn()

    {
        // works but still the odd exception

        sandwichToCheck = socketInteractor.selectTarget.gameObject;
        if (sandwichToCheck.GetComponent<Bread>().sandwichComplete)
        {
            Debug.Log("Your sandwich is compatible");
            sandwichIn = true;

        }

        else
        {
            Debug.Log("Piss off with that shitty bread");
            sandwichToCheck.gameObject.SetActive(false);
        }
        
    }

    public void SetSandwichOff()
    {
        sandwichIn = false;

    }

    // Universal Functions

    private void Start()
    {
      if (gameManager.GetComponent<GameManager>().sceneName == gameManager.GetComponent<GameManager>().sceneName_1)
        {
            Debug.Log("Following Scene 1");
            socketHummus.gameObject.SetActive(true);
            socketBreadstick.gameObject.SetActive(true);
            socketOlives.gameObject.SetActive(true);
            socketSandwich.gameObject.SetActive(false);


        }

        if (gameManager.GetComponent<GameManager>().sceneName == gameManager.GetComponent<GameManager>().sceneName_2)
        {
            Debug.Log("Following Scene 2");
            socketHummus.gameObject.SetActive(false);
            socketBreadstick.gameObject.SetActive(false);
            socketOlives.gameObject.SetActive(false);
            socketSandwich.gameObject.SetActive(true);

            socketInteractor = socketSandwich.GetComponent<XRSocketInteractor>();
            


        }

    }


  
    private void Update()
    {
        if (gameManager.GetComponent<GameManager>().sceneName == gameManager.GetComponent<GameManager>().sceneName_1)
        {
            if (olivesIn && breadsticksIn && hummusIn)
            {
                Debug.Log("PLATE LOADED");
                plateLoaded = true;
            }
            else
            {
                plateLoaded = false;
            }
        }

        if (gameManager.GetComponent<GameManager>().sceneName == gameManager.GetComponent<GameManager>().sceneName_2)
        {
            if (sandwichIn)
            {
                Debug.Log("PLATE LOADED");
                plateLoaded = true;
            }
            else
            {
                plateLoaded = false;
            }
        }



    }
}
