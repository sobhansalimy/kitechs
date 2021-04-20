using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject[] Models;
    public GameObject[] Icons;
    public GameObject NotPrefab;
    public GameObject tile;
    public GameObject jadval;
    public GameObject tree;
    public GameObject rock;
    public GameObject orange;
    public GameObject man;
    public GameObject mask;
    public Transform GameWorld;
    public Transform Tileins;
    public Transform jadvachapins;
    public Transform jadvalrastins;
    public Transform ins;
    public Transform ins1;
    public Transform ins2;
    public Transform ins3;
    public Transform ins4;
    public Transform ins5;
    public Transform sabzehchap;
    public Transform sabzehrast;


    public int a;

    public Vector3 rot;
    float next_spawn_time_tile;
    float next_spawn_time_jadval;

    [Range(0.95f, 1.00f)]
    public float Holdzaman;
    [Range(0.95f, 1.00f)]
    public float HoldzamanOfsabze;

    void Start()
    {
        a = 1;
        //start off with next spawn time being 'in 5 seconds'
        next_spawn_time_tile = Time.time + 0.4f;
        next_spawn_time_jadval = Time.time + 0.6f;


    }

 
    void Update()
    {
        float awnserhold = Random.Range(0f, 10f);
        float zamanRandom = Random.Range(0f, 1f);
        float makanRandom = Random.Range(0f, 5f);

        float zamansabzehRandom = Random.Range(0f, 1f);
        float trorrocksabzehRandom = Random.Range(0f, 2f);
        float makansabzehRandom = Random.Range(0f, 2f);


        //sabze

        if (zamansabzehRandom > Holdzaman)
        {
            if (trorrocksabzehRandom <= 1f)
            {
                GameObject orrock = Instantiate(rock) as GameObject;
                orrock.transform.parent = ins;
                orrock.transform.rotation = GameWorld.transform.rotation;
                if (makansabzehRandom <= 1f) orrock.transform.position = sabzehchap.transform.position;
                else if (makansabzehRandom >= 1f && makansabzehRandom < 2f) orrock.transform.position = sabzehrast.transform.position;
            }
            else if (trorrocksabzehRandom >= 1f && trorrocksabzehRandom < 2f){
                GameObject ortree = Instantiate(tree) as GameObject;
                ortree.transform.parent = ins;
                ortree.transform.rotation = GameWorld.transform.rotation;
                if (makansabzehRandom <= 1f) ortree.transform.position = sabzehchap.transform.position;
                else if (makansabzehRandom >= 1f && makansabzehRandom < 2f) ortree.transform.position = sabzehrast.transform.position;
            }

        }



        //jadval

        if (Time.time > next_spawn_time_tile)
        {
            GameObject myTile = Instantiate(tile) as GameObject;
            myTile.transform.parent = ins;
            myTile.transform.position = Tileins.transform.position;
            myTile.transform.rotation = GameWorld.transform.rotation;
            //increment next_spawn_time
            next_spawn_time_tile += 0.3f;
        }

        if (Time.time > next_spawn_time_jadval)
        {
            GameObject myjadval1 = Instantiate(jadval) as GameObject;
            myjadval1.transform.parent = ins;
            myjadval1.transform.position = jadvachapins.transform.position;
            myjadval1.transform.rotation = GameWorld.transform.rotation;


            GameObject myjadval2 = Instantiate(jadval) as GameObject;
            myjadval2.transform.parent = ins;
            myjadval2.transform.position = jadvalrastins.transform.position;
            myjadval2.transform.rotation = GameWorld.transform.rotation;
             //increment next_spawn_time
            next_spawn_time_jadval += 0.4f;
        }


        //awnsers
        /* if (awnserhold <= 1f) a = 1;
         else if (awnserhold >= 1f && awnserhold < 2f) a = 2;
         else if (awnserhold >= 2f && awnserhold < 3f) a = 3;
         else if (awnserhold >= 3f && awnserhold < 4f) a = 4;
         else if (awnserhold >= 4f && awnserhold < 5f) a = 5;
         else if (awnserhold >= 5f && awnserhold < 6f) a = 6;
         else if (awnserhold >= 6f && awnserhold < 7f) a = 7;
         else if (awnserhold >= 7f && awnserhold < 8f) a = 8;
         else if (awnserhold >= 8f && awnserhold < 9f) a = 9;
         else if (awnserhold >= 9f && awnserhold < 10f) a = 10;*/

        



        //icons

        for (int i = 0; i < 11; i++)
        {
            if (i == a) Icons[i].SetActive(true); 
            else Icons[i].SetActive(false);
        }



        //Icons[a].SetActive(true);

        //street

        if (zamanRandom > Holdzaman)
         {

            GameObject my3d = Instantiate(Models[a]) as GameObject;      
              my3d.transform.parent = ins;
              my3d.transform.rotation = GameWorld.transform.rotation;
              if (makanRandom <= 1f) my3d.transform.position = ins1.transform.position;
              else if (makanRandom >= 1f && makanRandom < 2f) my3d.transform.position = ins2.transform.position;
              else if (makanRandom >= 2f && makanRandom < 3f) my3d.transform.position = ins3.transform.position;
              else if (makanRandom >= 3f && makanRandom < 4f) my3d.transform.position = ins4.transform.position;
              else if (makanRandom >= 4f && makanRandom < 5f) my3d.transform.position = ins5.transform.position;



        }




    }

}
