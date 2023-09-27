using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    public Rigidbody2D rb;
    public float movespeed;
    public float ShiftKeyNitro;
    public bool moveright;
    public bool moveleft;
    public bool jump;
    public bool sprint;
    public float jumpheight;
    public int collectedCrystals;
    private Animator anim;
    public int crystalGoal;
    private SpriteRenderer mySpriteRenderer;

    // This function is called just one time by Unity the moment the component loads
    private void Awake()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Walking", false);
        if(onGround==true){
            anim.SetBool("Jump", false);
        }else{
            anim.SetBool("Jump", true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mySpriteRenderer.flipX = true;
            if(onGround){
                anim.SetBool("Walking", true);
            }
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity = new Vector2(-movespeed*ShiftKeyNitro, rb.velocity.y);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            mySpriteRenderer.flipX = false;
            if (onGround){
                anim.SetBool("Walking", true);
            }
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.velocity = new Vector2(movespeed*ShiftKeyNitro, rb.velocity.y);
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if(onGround==true){
                rb.velocity = new Vector2(rb.velocity.x, jumpheight);
                jump = true;
            }
            else{
                jump = false;
            }
        }
        if (moveright)
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);
            if (sprint)
            {
                rb.velocity = new Vector2(movespeed*ShiftKeyNitro, rb.velocity.y); 
                // if the variable isn't empty (we have a reference to our SpriteRenderer
                if(mySpriteRenderer != null)
                {
                    // flip the sprite
                    mySpriteRenderer.flipX = false;
                }
            }
        }
        if (moveleft)
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
            if (sprint)
            {
                rb.velocity = new Vector2(-movespeed*ShiftKeyNitro, rb.velocity.y); 
                // if the variable isn't empty (we have a reference to our SpriteRenderer
                if(mySpriteRenderer != null)
                {
                    // flip the sprite
                    mySpriteRenderer.flipX = true;
                }
            }
        }
        if (jump)
        {
            if(onGround==true){
                rb.velocity = new Vector2(rb.velocity.x, jumpheight);
                jump = false;
            }
            else{
                jump = false;
            }
        }
        
        // if (rb.velocity.x != 0 && onGround)
        // {
        //     anim.SetBool("Walking", true);
        // } else {
        //     anim.SetBool("Walking", false);
        // }

        if (collectedCrystals == crystalGoal)
        {
            SceneManager.LoadScene("level2");
        }
    }

    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
}
