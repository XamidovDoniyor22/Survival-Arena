using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
    [SerializeField]
    private int enemyCount;

    [SerializeField]
    private Text enemyText;

    private void Update()
    {
        enemyText.text = enemyCount.ToString();
    }

    public void CountEnemy()
    {
        enemyCount++;
    }
}

