using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMover : MonoBehaviour
{
    //class variables go here
    public float speed;
    public float xMax;
    public float xMin;

    // Start is called before the first frame update
    void Start()
    {
        //type nameOfVariable = 
        //Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + Vector3.right * speed;
        transform.position = newPosition;

        if (transform.position.x > xMax)
        {
            speed = speed * -1;
        }
        if (transform.position.x < xMin)
        {
            speed = speed * -1;
        }

    }
}
