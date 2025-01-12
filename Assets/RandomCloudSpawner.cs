using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomCloudSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] cloudTypes;
    [SerializeField] private GameObject[] chosenSpawn;

    [SerializeField] private float spawnInterval;

    private List<GameObject> selectedClouds = new List<GameObject>();

    private bool UNSTOPPABLE = false;
    
    private int amountOfClouds;
    private int offset = 0;

    void Start()
    {
        StartCoroutine(CloudSpawner());
    }


    private IEnumerator CloudSpawner()
    {
        while(!UNSTOPPABLE)
        { 

            //set amount of clouds to appear per cycle
            amountOfClouds = Random.Range(1, 4);

            for (int i = 0; i < amountOfClouds; i++)
            {
                int rng = Random.Range(0, 4);
                selectedClouds.Add(cloudTypes[rng]);
            }

            Debug.Log("hello");

            for (int i = 0; i < amountOfClouds; i++)
            {

                int rng = Random.Range(0, 5);
                Instantiate(selectedClouds[i], chosenSpawn[rng].transform);
                yield return new WaitForSeconds(spawnInterval);
            }
        }

        yield break;
    }
}
