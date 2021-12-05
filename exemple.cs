using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exemple : MonoBehaviour
{

    void Start()
    {
     
    }

    void Update()
    {
        
    }

    int Sum(int a, int b)
    {
        return a + b;

    }

    float Prod(float a, float b)
    {
        return a * b;

    }
    float division(float a, float b)
    {
        if (b == 0)
        { 
            Debug.Log("desolé");
            return -1;
        }
        else
            return a / b;

    }

}


































