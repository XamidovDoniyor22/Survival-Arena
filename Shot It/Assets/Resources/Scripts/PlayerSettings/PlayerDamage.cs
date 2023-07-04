using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField]
    private int health = 100;

    

    [SerializeField]
    private HealthBarScript healthBarScript;
    [SerializeField]
    private RestartGame gameRestart;


   private void Start()
    {
       gameRestart = GameObject.Find("GameRestart").GetComponent<RestartGame>();
      
     
        healthBarScript = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<HealthBarScript>();
        healthBarScript.SetMaxHealth(health);
    }
    private void Update()
    {
        HealthCheck();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Sword": SwordDamage(); break;
           
        }
    }
    private void SwordDamage()
    {
          health -= 5;
          healthBarScript.SetHealth(health);
        
    }
    private void HealthCheck()
    {
        if(health <= 0) gameRestart.GameRestart();
    }
   
 
  
   
}
