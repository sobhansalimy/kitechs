using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoyOfMaze : MonoBehaviour
{
    private Rigidbody rb;
    private float dirx;
    private float dirz;
    float speed = -0.7f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Forward()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void Backward()
    {
        transform.position += transform.forward * speed * Time.deltaTime *-1;
    }

    public void Right()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
    public void Left()
    {
        transform.position += transform.right * speed * Time.deltaTime * -1;
    }
}
