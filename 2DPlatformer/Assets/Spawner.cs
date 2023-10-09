using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{

    public GameObject platformPrefab;

    public GameObject previousPlatform;
    public GameObject cat;
    [Range(0f, 25f)]
    public float xRange = 8;
    [Range(0f, 25f)]
    public float yRange = 5;


    // Start is called before the first frame update
    void Start()
    {
       float randomFloat = Random.Range(-1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(previousPlatform.transform.position.x - cat.transform.position.x < 10)
        {
            Vector3 newPosition = previousPlatform.transform.position + new Vector3
            (15 + Random.Range(-xRange, xRange), Random.Range(-yRange, yRange), 0);


            previousPlatform = Instantiate(platformPrefab, newPosition, 
                Quaternion.identity);
        }


    }
}
