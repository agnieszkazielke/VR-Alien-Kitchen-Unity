using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServingCheck : MonoBehaviour
{

    public bool plateServed;

    // Start is called before the first frame update
    public void SetPlateServed()
    {
        plateServed = true;
    }

    public void UndoPlateServed()
    {
        plateServed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (plateServed)
        {
            Debug.Log("YOU SERVED THE PLATE");

        }

    }
}
