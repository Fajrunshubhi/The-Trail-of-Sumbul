using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){  
        if(collision.gameObject.CompareTag("Player")){           
            GameManager.Instance.setKoin(1);
            Destroy(gameObject);           
        }
    }
}
