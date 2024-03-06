using UnityEngine;


[RequireComponent(typeof(PlayerSnakeController))]
public class PlayerSnakeMovement : Movement
{
    private PlayerSnakeController _playerSnakeController;

    void Awake()
    {
        _playerSnakeController = GetComponent<PlayerSnakeController>();
    }

    private void Start()
    {
        _speed = 3.0f;
    }


    private void Update()
    {
        Move(DirUtils.GetDir(_playerSnakeController._direction));


    }
}