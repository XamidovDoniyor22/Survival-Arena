using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    [SerializeField]
    private Text healthNumber;

    private void Update()
    {
        healthNumber.text = slider.value.ToString() + "/100";
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

    }

    public void SetHealth(int health)
    {
        slider.value = health;  
    }
}
