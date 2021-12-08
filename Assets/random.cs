using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
    public GameObject enemy;
    public float timer=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>2)
        {
            Instantiate(enemy,new Vector3(0, Random.Range(20,-20),0), Quaternion.identity);
            timer = 0;
        }
    }
}
