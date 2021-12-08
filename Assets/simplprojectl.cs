using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplprojectl : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }
    private void OnCollisionEnter2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag.Equals("enemy"))
        {
            Destroy(enemy.gameObject);
            Destroy(gameObject);
        }

    }
}
