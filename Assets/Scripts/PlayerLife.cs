using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public PlayerMovement playerMovement;

    public Animator anim;
    public int maxHealth = 5;
    public int health;
    public SpriteRenderer playerSr;
    public Rigidbody2D rb;
    bool isHurting, isDead;
    Vector3 localScale;



    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator>();
        health = maxHealth;
    }

    void Update(){
        // SetAnimationState();
    }
    void FixedUpdate(){

    }


    public void TakeDamage(int amount){
        health -= amount;
        // anim.SetTrigger("TriggerDeath");
        // // anim.SetTrigger("TriggerHit");
        // if(health <= 0){
        //     // player dead
        //     // player dead animation
        //     // anim.SetBool("IsDead", true);
        //     // show gameOver screen
        //     // playerSr.enabled = false;
        //     // playerMovement.enabled = false;
        //     Destroy(gameObject, 0.5f);
        // }
    }

    private void OnTriggerEnter2D(Collider2D collision){  
        if(collision.gameObject.CompareTag("Enemy")){
            anim.SetBool("IsHit", true);
            if(health <= 1){
                anim.SetBool("IsHit", false);
                anim.SetBool("IsDead", true);
                Destroy(gameObject, 1f);
                
            }
            Debug.Log(health-1);    
        } 
    }
    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Enemy")){
            anim.SetBool("IsHit", false);     
        } 
    }
}
