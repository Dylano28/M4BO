using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform Gunpoint;
    public GameObject Bulletprefab;

    // Update is called once per frame
    void Update()
    {
      if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot ()
    {
        Instantiate(Bulletprefab, Gunpoint.position, Gunpoint.rotation);
    }
}
