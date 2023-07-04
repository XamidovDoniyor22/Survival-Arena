using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour
{
    [SerializeField]
    private float timeNextTime;
    [SerializeField]
    private float timeShooting;

    [SerializeField]
    private Transform pointOfShooting;

    [SerializeField]
    private GameObject bulletPrefab;




    public void Shooting()
    {
        if (timeShooting < 0)
        {
            Instantiate(bulletPrefab, pointOfShooting.position, transform.rotation);
            timeShooting = timeNextTime;
          
        }
        else
        {
            timeShooting -= Time.deltaTime;
        }
    }


}
