using UnityEngine;

public class RayGun : MonoBehaviour
{
    public Transform firePoint;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {

    }
}
