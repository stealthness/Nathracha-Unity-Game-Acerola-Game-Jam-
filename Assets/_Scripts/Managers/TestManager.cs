using UnityEngine;


public class TestManager : MonoBehaviour
{


    private void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("TM::Escape");
            GameManager.Instance.PauseGame();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("TM::Space");
            GameManager.Instance.GameOver();
        }
    }
}