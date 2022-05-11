using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleAlien : MonoBehaviour
{

    private float speed = 1.0f;
    private float rotationSpeed = 1.0f;
    private float timeDelay = 7.0f;
    private float boundaryLeft = -11.0f;
    private float boundaryRight = -2.0f;
    private Vector3 targetAngles;



    // Start is called before the first frame update
    void Start()
    {

        targetAngles = transform.eulerAngles + 180f * Vector3.up;
            

    }

    private void RotateAlien180Clockwise()
    {

       transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetAngles, rotationSpeed * Time.deltaTime);
        
    }

    private void RotateAlien180AntiClockwise()
    {

        transform.Rotate(Vector3.up * -180.0f);
        

    }

    private void MoveForward()
    {

        transform.Translate(speed * Time.deltaTime * Vector3.forward);

    }

    private void MoveForwardSlow()
    {

        transform.Translate(speed * 0.5f * Time.deltaTime * Vector3.forward);

    }


    // Update is called once per frame
    void Update()
    {

        if (transform.position.z > boundaryLeft && transform.position.z < boundaryRight)
        {
            MoveForward();
                        
        }

        if (transform.position.z <= boundaryLeft)
        {
            RotateAlien180Clockwise();
            Invoke("MoveForwardSlow", timeDelay);
        }

        if (transform.position.z >= boundaryRight)
        {
            RotateAlien180AntiClockwise();
            Invoke("MoveForwardSlow", timeDelay);
        }

    }

}



