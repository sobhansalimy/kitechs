using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject StarVFX;
    public Animator anim;
    public AudioSource Gain;

    public GameObject boy;
    public Transform LOC;
    public Transform ins1; 
    public Transform ins2;
    public Transform ins3;
    public Transform ins4;
    public Transform ins5;
    private int location;
    private int onetime;
    private float mask;
    private float orange;

    private int p;
    private int level;
    private int rank;
    private int levelcont;
    public int awnser;
    private float speed = 1f;



    // public GameObject lose;

    void Start()
    {
        rank=1;
        level = PlayerPrefs.GetInt("levelofrun");
       /* PlayerPrefs.SetInt("levelofrun", 0);
        PlayerPrefs.Save();*/
        if (level == 0)
        {
            level = 1;
            PlayerPrefs.SetInt("levelofrun", 1);
            PlayerPrefs.Save();
        }
        p =0;
        onetime = 10;
        location = 0;

        anim = GetComponent<Animator>();
        awnser = GameObject.Find("Ins").GetComponent<Instantiate>().a; 
    }

    // Update is called once per frame
    void Update()
    {
        awnser = GameObject.Find("Ins").GetComponent<Instantiate>().a;
        level = PlayerPrefs.GetInt("levelofrun");

        anim.SetBool("IsWalking", true);
        anim.SetBool("IsRuning", true);
        // anim.SetBool("IsStop", true);


        if (location <= -3) location = -2;
        else if (location >= 3) location = 2;
        else if (location == -2)
        {
            //boy.transform.position = ins1.transform.position;
            boy.transform.position = Vector3.MoveTowards(boy.transform.position, ins1.position, speed * Time.deltaTime);
        }
        else if (location == -1)
        {
            //boy.transform.position = ins2.transform.position;
            boy.transform.position = Vector3.MoveTowards(boy.transform.position, ins2.position, speed * Time.deltaTime);
        }
        else if (location == 0)
        {
            //boy.transform.position = ins3.transform.position;
            boy.transform.position = Vector3.MoveTowards(boy.transform.position, ins3.position, speed * Time.deltaTime);
        }
        else if (location == 1)
        {
            //boy.transform.position = ins4.transform.position 
            

            boy.transform.position = Vector3.MoveTowards(boy.transform.position, ins4.position, speed * Time.deltaTime);
        }
        else if (location == 2)
        {
            //boy.transform.position = ins5.transform.position;
            boy.transform.position = Vector3.MoveTowards(boy.transform.position, ins5.position, speed * Time.deltaTime);
        }



        //level up
        levelcont = level * 5;
        if (p >= levelcont)
        {
            rank++;
            GameObject.Find("Ins").GetComponent<Instantiate>().a = rank;
            p = 0;
        }
        

    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "apple")
        {
            Destroy(col.gameObject);
            if (awnser == 1)
            {
                rhigtAwnser();
                p++;
            }
            else falseAwnser();
            
        }
        if(col.collider.tag == "orange")
        {
            Destroy(col.gameObject);
            if (awnser == 2)
                {
                    rhigtAwnser();
                    p++;
                }
            else falseAwnser();
            
        }
        if (col.collider.tag == "bread")
        {
            Destroy(col.gameObject);
            if (awnser == 3)
            {
                rhigtAwnser();
                p++;
            }
            else falseAwnser();

        }
        if (col.collider.tag == "shoes")
        {
            Destroy(col.gameObject);
            if (awnser == 4)
            {
                rhigtAwnser();
                p++;
            }
            else falseAwnser();

        }
        if (col.collider.tag == "coca")
        {
            Destroy(col.gameObject);
            if (awnser == 5)
            {
                rhigtAwnser();
                p++;
            }
            else falseAwnser();

        }
        if (col.collider.tag == "brush")
        {
            Destroy(col.gameObject);
            if (awnser == 6)
            {
                rhigtAwnser();
                p++;
            }
            else falseAwnser();

        }
        if (col.collider.tag == "toothcream")
        {
            Destroy(col.gameObject);
            if (awnser == 7)
            {
                rhigtAwnser();
                p++;
            }
            else falseAwnser();

        }
        if (col.collider.tag == "tshirt")
        {
            Destroy(col.gameObject);
            if (awnser == 8)
            {
                rhigtAwnser();
                p++;
            }
            else falseAwnser();

        }
        if (col.collider.tag == "coin")
        {
            Destroy(col.gameObject);
            if (awnser == 9)
            {
                rhigtAwnser();
                p++;
            }
            else falseAwnser();

        }
        if (col.collider.tag == "pant")
        {
            Destroy(col.gameObject);
            if (awnser == 10)
            {
                rhigtAwnser();
                p++;
                if(p >= levelcont)
                {
                    level++;
                    rank = 1;
                    GameObject.Find("Ins").GetComponent<Instantiate>().a = rank;
                    PlayerPrefs.SetInt("levelofrun", level);
                    PlayerPrefs.Save();
                }

            }
            else falseAwnser();

        }
    }


    public void Right()
    {
        location++;
        onetime = 0;
    }
    public void Left()
    {
        location--;
        onetime = 0;
    }

    public void rhigtAwnser()
    {
        GameObject star = Instantiate(StarVFX) as GameObject;
        star.transform.position = LOC.transform.position ;
        Gain.Play();
    }

    public void falseAwnser()
    {

    }

}
