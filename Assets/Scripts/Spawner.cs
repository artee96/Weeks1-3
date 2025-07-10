using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Vector3 spawnPoint;
    public int framerate;
    List<GameObject> spawnedObjects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = framerate;


        //GameObject spawnedObject = Instantiate(prefabToSpawn);
        //spawnedObjects.Add(spawnedObject);

        //GameObject spawnedObject2 = Instantiate(prefabToSpawn, spawnPoint, Quaternion.identity);
        //Destroy(spawnedObject2, 3);
        //spawnedObjects.Add(spawnedObject2);

        //Destroy(spawnedObjects[0]);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject spawnedObject = Instantiate(prefabToSpawn);
            spawnedObjects.Add(spawnedObject);
        }
        if (Input.GetMouseButtonDown(1))
        {
            for (int i = 0; i < spawnedObjects.Count; i++)
            {
                Destroy(spawnedObjects[i]);             
            }
            spawnedObjects.Clear();
        }

        //references: https://www.w3schools.com/cs/cs_arrays.php 
        //https://www.delftstack.com/howto/csharp/iterate-through-a-list-in-csharp/#google_vignette
    }
}
