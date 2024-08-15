using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Ch_movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float Ch_mov,mov_ver;
    public bool ch_facingR = true;
    public Sprite idle;
    public Sprite[] sprites;
    Vector2 movement;
    public SpriteRenderer spriteRenderer;
    private int frame;

    
    public void Update(){
        Ch_mov = Input.GetAxis("Horizontal");
        mov_ver = Input.GetAxis("Vertical");
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        if(Ch_mov != 0){
            Animate();
        }
        else if(mov_ver != 0){
            Animate();
        }
        else if(Ch_mov == 0 && mov_ver == 0){
            spriteRenderer.sprite = idle;
        }
        if(Ch_mov > 0 && ch_facingR == false){
            Turn();
        }
        else if(Ch_mov < 0 && ch_facingR == true){
            Turn();
        }
    }
    private void FixedUpdate(){
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }   
    public void Turn(){
        ch_facingR = !ch_facingR;
        transform.localScale = new Vector2(-transform.localScale.x,transform.localScale.y);
    }
    private void Animate(){
        frame = frame + 1;
        if(frame >= sprites.Length){
            frame = 0;
        }
        
        if(frame >= 0 && frame <= sprites.Length){
            spriteRenderer.sprite = sprites[frame];
        }
        Thread.Sleep(70);
    }
}
