using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMechanism : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed;
 
    private void Update()
    {    
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);  
    }
}
