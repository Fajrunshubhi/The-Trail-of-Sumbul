using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{

    public Sprite flatSprite;
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player")){
            if(collision.transform.DotTest(transform, Vector2.down)){
                Flatten();
                Debug.Log("hmm");
            }
            
        }
    }

    private void Flatten(){
        // GetComponent<Collider2D>().enabled = false;
        // GetComponent<SpriteRenderer>().sprite = flatSprite;
        // GetComponent<AnimatedSprite>().enable = false;
        GetComponent<EnemyMovement>().enabled = false;
        Destroy(gameObject, 0.5f);
    }
}
