using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Animator anim;

    public GameObject gameOverScreen;
    

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update(){
        
    }
    void FixedUpdate(){

    }
    public void TakeDamage(int amount){
        GameManager.Instance.Hit(amount);
    }
    

    private void OnTriggerEnter2D(Collider2D collision){  
        if(collision.gameObject.CompareTag("Enemy")){
            anim.SetBool("IsHit", true);
            if(GameManager.Instance.lives <= 0){
                anim.SetBool("IsHit", false);
                anim.SetBool("IsDead", true);
                GameManager.Instance.gameOver(gameOverScreen);
            }            
        } 
        if(collision.gameObject.CompareTag("Water")){
            // OPTION 1X HIT LANGSUNG MATI
            // GameManager.Instance.DeadByWater(5);
            // OPTION 5X HIT
            GameManager.Instance.Hit(1);
            anim.SetBool("IsHit", true);
            if(GameManager.Instance.lives <= 0){
                anim.SetBool("IsHit", false);
                anim.SetBool("IsDead", true);
                playerMovement.enabled = false;
                GameManager.Instance.gameOver(gameOverScreen);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Enemy")){
            anim.SetBool("IsHit", false);     
        } 
        if(collision.gameObject.CompareTag("Water")){
            anim.SetBool("IsHit", false); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("TrapHit")){
            GameManager.Instance.Hit(1);
            anim.SetBool("IsHit", true);
            if(GameManager.Instance.lives <= 0){
                anim.SetBool("IsHit", false);
                anim.SetBool("IsDead", true);
                playerMovement.enabled = false;
                GameManager.Instance.gameOver(gameOverScreen);
            } 
        }
    }
    private void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.CompareTag("TrapHit")){
            anim.SetBool("IsHit", false);
        }
    }

    public void PauseGame(){
        GameManager.Instance.PauseGame();
    }
}
