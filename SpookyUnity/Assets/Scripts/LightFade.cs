using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFade : MonoBehaviour
{
    [SerializeField]
    UnityEngine.Experimental.Rendering.Universal.Light2D Light2D;

    private float minLuminosity = 0;
    private float maxLuminosity = 1;

    float counter = 0f;

    void Start()
    {
        maxLuminosity = 1;
    }


    void Update()
    {
        
    }
}
