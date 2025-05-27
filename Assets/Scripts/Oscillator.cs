using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motiontoobstacles : MonoBehaviour
{
    Vector3 startPos;
    [SerializeField] Vector3 movvector;
    [SerializeField] [Range(0,1)] float movfactor;
    [SerializeField] float period;
    
        void Start()
    {
        startPos= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (period<=Mathf.Epsilon){return;}
        float cycles= Time.time / period;
        const float tau = Mathf.PI*2;
        float rawSinWave= Mathf.Sin(cycles*tau);
        movfactor=(rawSinWave+1f)/2f;
        Vector3 offset= movvector*movfactor;
        transform.position= startPos+offset;
    }
}
