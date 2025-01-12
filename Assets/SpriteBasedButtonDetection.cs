using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteBasedButtonDetection : MonoBehaviour
{
    private float treshhold = .1f;

    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = treshhold;
    }

}
