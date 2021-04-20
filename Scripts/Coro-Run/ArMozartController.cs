using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArMozartController : MonoBehaviour
{

    public float scale = 1f;
    public GameObject World;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AdjustScale(float newScale)
    {
        World.transform.localScale = new Vector3(newScale, newScale, newScale);
        Debug.Log(newScale);
    }
}
