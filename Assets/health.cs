using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int maxhealth = 10;
    public int currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxhealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
}
