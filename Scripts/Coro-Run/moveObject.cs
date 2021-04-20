using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
    float speed = -0.7f;
    private float rotate;
    private float mask;
    private float orange;

    private int awnser;



    void Start()
    {

    }
    void Update()
    {
        //Debug.Log(x);
       //if(x == 0)  transform.Translate(0, speed * Time.deltaTime,0 );
      //   transform.Translate(0,0 , speed * Time.deltaTime);
      transform.position += transform.forward * speed * Time.deltaTime;



       /* float distance = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("Boy").transform.position);
        if(distance <= 0.1f && distance >= -0.1f)
        {
            if (gameObject.tag == "apple") {
                if (awnser == 1) rhigtAwnser();
                else falseAwnser();
                Destroy(gameObject);
            }
            else if (gameObject.tag == "orange")
            {
                if (awnser == 2) rhigtAwnser();
                else falseAwnser();
                Destroy(gameObject);
            }
           
        }*/

        Destroy(gameObject, 2.1f);

    }




}
