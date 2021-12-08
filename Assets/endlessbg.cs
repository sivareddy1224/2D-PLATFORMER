using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessbg : MonoBehaviour
{
    public float speed;
    public float startpos;
    public float endpos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= endpos)
        {
            Vector2 bgpos = new Vector2(startpos, transform.position.y);
            transform.position = bgpos;
        }
    }
}
