using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float movespeed = 5f;
    public simplprojectl projPrefab;
    public Transform ProjectileOffset;
    public int health = 100;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        float hrzntlmove = Input.GetAxisRaw("Horizontal");
        float vrtclmove = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(hrzntlmove, vrtclmove, 0) * movespeed * Time.deltaTime);
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projPrefab, ProjectileOffset.position, transform.rotation);
        }

    }

}
