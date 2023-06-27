using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject SwordOnPLayer;
    // Start is called before the first frame update
    void Start()
    {
        SwordOnPLayer.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag== "Player")
        {
            if(Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                SwordOnPLayer.SetActive(true);
            }
        }
    }
}
