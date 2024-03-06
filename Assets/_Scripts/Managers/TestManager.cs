using UnityEngine;


public class TestManager : MonoBehaviour
{


    private void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("TM::Escape");
        }
    }
}