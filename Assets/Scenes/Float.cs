using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    public float freq;
    public float amp;
    Vector3 initPos;
    // Update is called once per frame
    private void Start()
    {
        initPos = transform.position;
    }
    void Update()
    {
        transform.position = new Vector3(initPos.x, Mathf.Sin(Time.time *freq)* amp + initPos.y,0);
    }
}
