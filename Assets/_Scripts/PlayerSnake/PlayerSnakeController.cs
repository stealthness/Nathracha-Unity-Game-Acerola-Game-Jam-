using UnityEngine;


public class PlayerSnakeController : MonoBehaviour
{
    public Vector2 _direction { get; private set; }


    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        _direction = new Vector2(x, y).normalized;
        Debug.Log("PSC::Update: " + _direction);
    }
}