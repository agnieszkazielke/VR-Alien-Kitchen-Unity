using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{

    public GameObject targetPos;
    public GameObject textCloud;
    public float speed = 5.0f;
    public float rotationSpeed = 0.5f;
    private GameManager gameManager;
    private Rigidbody alienRb;
    private Animator alienAnim;
    private Vector3 startPos;
    private Vector3 targetDirection;
    private Quaternion LookDirection;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        startPos = transform.position;
        alienRb = GetComponent<Rigidbody>();
        alienAnim = GetComponent<Animator>();
        targetDirection = new Vector3(5, 0, 0); ;
        LookDirection = Quaternion.LookRotation(targetDirection);
    }

    public void AlienSlap()
    {
        alienAnim.SetBool("Slap", true);
    }

    // Update is called once per frame
    
    void Update()
    {
      

        if (gameManager.dishServed)
        {
            if (transform.position.z < targetPos.transform.position.z)
            {
                alienAnim.SetBool("Walks", true);
                transform.Translate(speed * Time.deltaTime * (targetPos.transform.position - transform.position));
                

            }

            else

            {
                transform.rotation = Quaternion.Slerp(transform.rotation, LookDirection, Time.deltaTime * rotationSpeed);
                alienAnim.SetBool("Walks", false);
                textCloud.gameObject.SetActive(true);
            }
        }


        
    }
}
