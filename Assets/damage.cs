using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    public int damaged = 1;
    public float speed=10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("siva"))
        {
            other.GetComponent<move>().health -= damaged;
            Debug.Log(other.GetComponent<move>().health);
            Destroy(gameObject);

        }
    }
    private void Update()
    {


        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}