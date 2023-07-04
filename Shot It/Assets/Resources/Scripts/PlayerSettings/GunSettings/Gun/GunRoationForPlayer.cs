using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRoationForPlayer : MonoBehaviour
{
    [SerializeField]
    private float rotZ;

    [SerializeField]
    private Joystick joystick;

    [SerializeField]
    private GunShooting shooting;

    private float offset = -180;

    private void Start()
    {
        shooting = GetComponent<GunShooting>(); 
    }
    private void Update()
    {
        float rotZ = Mathf.Atan2(joystick.Vertical, joystick.Horizontal) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ + offset);

        if(rotZ != 0)
        {
            shooting.Shooting();
        }
    }
}
