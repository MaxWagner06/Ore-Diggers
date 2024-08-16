using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Ch_movement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float speed;
    public float Ch_mov,mov_ver;
    public bool ch_facingR = true;
    Vector2 movement;

    
    public void Update(){
        Ch_mov = Input.GetAxis("Horizontal");
        mov_ver = Input.GetAxis("Vertical");
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");


        if(Ch_mov != 0)
        {
            //Walk
            animator.SetBool("onWalk", true);
        }
        else if(mov_ver != 0)
        {
            //Walk
            animator.SetBool("onWalk", true);
        }
        else if(Ch_mov == 0 && mov_ver == 0)
        {
            //idle
            animator.SetBool("onWalk", false);
        }
        if(Ch_mov > 0 && ch_facingR == false)
        {
            Turn();
        }
        else if(Ch_mov < 0 && ch_facingR == true)
        {
            Turn();
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }   
    public void Turn()
    {
        ch_facingR = !ch_facingR;
        transform.localScale = new Vector2(-transform.localScale.x,transform.localScale.y);
    }
}
