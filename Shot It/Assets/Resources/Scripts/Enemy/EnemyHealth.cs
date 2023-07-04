using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private int enemyHealth = 100;
    [SerializeField]
    private int swordDamage = 25;
    [SerializeField]
    private int bulletDamage = 50;

    [SerializeField]
    private EnemyCount enemyCount;

    private void Start()
    {
        enemyCount = GameObject.Find("EnemyCount").GetComponent<EnemyCount>();
    }

    private void Update()
    {
        HealthCheck();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Bullet": BulletDamage(); Destroy(collision.gameObject); break;
            case "SwordPlayer": SwordDamage();break;
        }
    }
    private void SwordDamage()
    {
        enemyHealth -= swordDamage;
    }
    private void BulletDamage()
    {
        enemyHealth -= bulletDamage;
    }
    private void HealthCheck()
    {
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
            enemyCount.CountEnemy();
        }
    }
}
