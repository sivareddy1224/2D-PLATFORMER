using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemypattern : MonoBehaviour
{
    public GameObject[] enemyptn;
  
    private float spawninterval;
    public float minspnintrvl;
    public float intialspawninterval;
    public float spntimereduction;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawninterval <= 0.5)
        {
            int rndm= Random.Range(0,enemyptn.Length);
            Instantiate(enemyptn[rndm],transform.position,Quaternion.identity);
            
            spawninterval = intialspawninterval;
            if (intialspawninterval > minspnintrvl)
            {
                intialspawninterval -= spntimereduction;
            }
        }


        else
        {
            spawninterval -= Time.deltaTime;
        }

    }
}