using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    private float timeAlive = 0f;
    public SpriteRenderer changerRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeAlive += Time.deltaTime;
        Debug.Log(timeAlive.ToString());
        if (timeAlive >= 3)
        {
            changerRenderer.color = Color.green;
        }
        //else if (timeAlive >= 4)
        //{
        //    changerRenderer.transform.localScale{};
        //}
    }
    //references: https://stackoverflow.com/questions/21636306/scale-gameobject-in-unity
}
