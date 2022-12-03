using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public Animator anim;
    public int maxHealth = 5;
    public int health;
    public SpriteRenderer playerSr;
    public PlayerMovement playerMovement;
    public float maxJumpHeight = 12f; // max jump
    public float maxJumpTime = 1f; // Waktu maksimal jump
    public float bounce => (5f * maxJumpHeight) / (maxJumpTime / 2f);


    void Start()
    {
        anim = GetComponent<Animator>();
        health = maxHealth;
    }


    public void TakeDamage(int amount){
        health -= amount;
        if(health <= 0){
            // player dead
            // player dead animation
            // anim.SetBool("IsDead", true);
            // show gameOver screen
            playerSr.enabled = false;
            playerMovement.enabled = false;
        }
    }
    

}
