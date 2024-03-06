using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameManager Instance;


    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }   
    }

    private void Start()
    {
        Debug.Log("GM::Start");
    }

    public void GameOver()
    {
        Debug.Log("GM::GameOver");
    }

    public void PauseGame()
    {
        Debug.Log("GM::PauseGame");
    }
}

public enum GameState
{
    Menu, Playing, Paused, GameOver
}
