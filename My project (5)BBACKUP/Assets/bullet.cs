using System.Collections;
using System.Collections.Generic; 
using UnityEngine;

public class bullet1 : MonoBehaviour
{
    float bulletSpeed = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += bulletSpeed * transform.up * Time.deltaTime;
    }
}
