using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    

    [SerializeField]
    private GameObject player;
    



    private void Start()
    {
        player = GameObject.Find("Player");
       
    }

    private void Update()
    {
        Chasing();
        FlipChecks();
       

     
    }

   
    protected virtual void Chasing()
    {
    
           transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, 
            speed * Time.deltaTime);
    }
    protected virtual void FlipChecks()
    {
        if(player.transform.position.x > transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
