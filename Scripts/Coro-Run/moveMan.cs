using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMan : MonoBehaviour
{
    float speed = 0.7f;
    private float rotate;
    public GameObject khata;
    public GameObject khata2;


    // Start is called before the first frame update

    void Start()
    {
        transform.Rotate(0, 180, 0);
    }
    void Update()
    {
        
        // transform.rotation = GameWorld.transform.rotation;
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(playerTarget.position - transform.position), rotate * Time.deltaTime);
        //transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        //transform.position = Vector3.MoveTowards(transform.position, playerTarget.position, speed * Time.deltaTime);
        transform.position += transform.forward * speed * Time.deltaTime;



        Destroy(gameObject, 2.1f);
        /* if (transform.position.z <= playerTarget.transform.position.z)
         {
             Destroy(gameObject);

         }*/

    }


}
