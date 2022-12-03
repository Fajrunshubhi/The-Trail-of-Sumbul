using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerLife playerHealth;
    public int damage = 1;
    
    private void OnCollisionEnter2D(Collision2D collision){
        StartCoroutine(Hurt());
        if(collision.gameObject.tag == "Player"){
            playerHealth.TakeDamage(damage);
        }
    }

    IEnumerator Hurt()
	{
		yield return new WaitForSeconds (5f);
        
	}
}
