using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServingBowl : MonoBehaviour
{
    public GameObject soup;
    public bool soupServed = false;
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ladle"))
        {
            Debug.Log("Ladle Detected");

            if (other.gameObject.GetComponent<Ladle>().ladleFull == true)
            {
                soup.gameObject.SetActive(true);
                soupServed = true;
            }
        }
    }

}


