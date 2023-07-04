using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    public float moveHor;
    [SerializeField]
    public float moveVert;
    [SerializeField]
    private Rigidbody2D rb;
    
    [SerializeField]
    public bool facingRight;

    [SerializeField]
    private Joystick joystick;

    [Space]
    [SerializeField]
    private Playeranimation playerAnimation;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Playeranimation>();  
       
    }
    private void Update()
    {
        moveHor = joystick.Horizontal;
        moveVert = joystick.Vertical;

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveHor * playerSpeed, moveVert * playerSpeed);
        
        FlipSideChecker();
        PlayerAnimation();
    }
   
    private void FlipSideChecker()
    {
        if (facingRight == false && moveHor > 0)
        {
            Flip();
        }
        if (facingRight == true && moveHor < 0)
        {
            Flip();
        }
    }
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
    private void PlayerAnimation()
    {
        if (moveHor != 0 || moveVert != 0)  playerAnimation.AnimationActive();
        
        else playerAnimation.AnimationDisactive();
    }



}
