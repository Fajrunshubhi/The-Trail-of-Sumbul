using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int lives { get; private set;}
    public string world { get; private set;}
    public int stage { get; private set;}
    public static GameManager Instance {
        get;
        private set;
    }

    private void Awake(){
        if(Instance != null){
            DestroyImmediate(gameObject);
        } else{
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start(){
        NewGame();
    }

    private void OnDestroy(){
        if(Instance == this){
            Instance = null;
        }
    }

    private void NewGame(){
        lives = 3;
        loadLevel("Level", 3);
    }
    private void loadLevel(string world, int stage){
        this.world = world;
        this.stage = stage;

        SceneManager.LoadScene($"{world}_{stage}");
    }


    public void resetLevel(){
        lives--;
        if(lives > 0){
            loadLevel(world, stage);
        } else{
            gameOver();
        }
    }
    public void resetLevel(float delay){
        Invoke(nameof(resetLevel), delay);
    }


    private void gameOver(){
        NewGame();
        // Invoke(nameof(NewGame), 3f); menunda 3detik
    }

    private void nextLevel(){
        loadLevel(world, stage-1);
    }
}
