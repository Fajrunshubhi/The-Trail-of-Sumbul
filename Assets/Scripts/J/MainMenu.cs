using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void loadLevel(int level){
        GameManager.Instance.loadLevel("Level", level);
    }
}
