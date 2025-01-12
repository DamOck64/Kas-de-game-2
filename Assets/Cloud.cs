using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float travelSpeed;
    public float cloudLifeTime;

    void Start()
    {
        Destroy(gameObject, cloudLifeTime);
        travelSpeed = Random.Range(200, 350);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(travelSpeed * Time.deltaTime, 0, 0);
    }
}
