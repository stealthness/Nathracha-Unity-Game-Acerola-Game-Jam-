using UnityEngine;

public class PlayerSnakeController : MonoBehaviour
{
    Vector2 _direction;


    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        _direction = new Vector2(x, y).normalized;
        Debug.Log("PSC::Update: " + _direction);
    }
}