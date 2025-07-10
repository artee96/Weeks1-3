using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Vector3 newPosition;
    public Camera gameCamera;
    public float speed;
    Vector3 lastClickedPosition = Vector3.zero;
    public SpriteRenderer chaserRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePositionInWorldSpace = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePositionInWorldSpace.z = 0f;

        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPosition = mousePositionInWorldSpace;
        }

        Vector3 start = transform.position;
        Vector3 target = lastClickedPosition;
        Vector3 directionToMove = target - start;

        transform.position = transform.position + directionToMove * speed;

        Vector3 chaserPositionInScreenSpace = gameCamera.WorldToScreenPoint(transform.position);
        float xMin = 0f;
        float yMin = 0f;
        float xMax = Screen.width;
        float yMax = Screen.height;

        bool xMaxExceeded = chaserPositionInScreenSpace.x >= xMax;
        bool xMinExceeded = chaserPositionInScreenSpace.x <= xMin;

        Debug.Log("xMaxExceeded =" + xMaxExceeded.ToString());
        Debug.Log("xMinExceeded =" + xMinExceeded.ToString());

        if (xMaxExceeded || xMinExceeded)
        {
            chaserRenderer.color = Color.red;
        }
        else
        {
            chaserRenderer.color = Color.white;
        }
    }
}
