using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeponChooseScript : MonoBehaviour
{
    [SerializeField]
    private GameObject joystickForPlayerGun;
    [SerializeField]
    private GameObject buttonForSword;

    [SerializeField]
    private GameObject gunSprite;
    [SerializeField]
    private GameObject swordSprite;
    public void GunChoose()
    {
        joystickForPlayerGun.SetActive(true);
        buttonForSword.SetActive(false);

        gunSprite.SetActive(true);
        swordSprite.SetActive(false);
    }
    public void SwordChoose()
    {
        joystickForPlayerGun.SetActive(false);
        buttonForSword.SetActive(true);
        
        gunSprite.SetActive(false);
        swordSprite.SetActive(true);
    }
}
