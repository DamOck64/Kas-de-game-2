using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMover : MonoBehaviour
{
    private int randomisedNumber;
    private int positionResetter;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator RandomiseCloudPosition()
    {
        randomisedNumber = Random.Range(-150, 151);
        if (randomisedNumber < 0)
        {
            positionResetter = -randomisedNumber - -randomisedNumber * 2;
        }
        else if (randomisedNumber > 0)
        {
            positionResetter = randomisedNumber - randomisedNumber * 2;
        }
        else if (randomisedNumber == 0)
        {
            positionResetter = 0;
        }
        yield break;
    }
}
