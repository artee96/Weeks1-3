using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool ifDownArrowIsPressed = Input.GetKeyDown(KeyCode.DownArrow);
        bool ifRightArrowIsPressed = Input.GetKey(KeyCode.RightArrow);
        bool ifUpArrowIsPressed = Input.GetKeyUp(KeyCode.UpArrow);

        if(ifDownArrowIsPressed == true)
        {
            Vector3 newDownPosition = transform.position + Vector3.up * -0.1f;
            transform.position = newDownPosition;
        }
        if(ifRightArrowIsPressed == true)
        {
            Vector3 newRightPosition = transform.position + Vector3.right * 0.5f;
            transform.position = newRightPosition;
        }
        if (ifUpArrowIsPressed == true)
        {
            Vector3 newUpPosition = transform.position + Vector3.up * 0.1f;
            transform.position = newUpPosition;
        }
    }
}
