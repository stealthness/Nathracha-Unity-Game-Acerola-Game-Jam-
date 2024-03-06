using UnityEngine;

public class Movement : MonoBehaviour
{
    internal float _speed = 1.0f;

    public void Move(Dir dir)
    {
        switch(dir)
        {
            case Dir.Up:
                transform.position += _speed * Vector3.up;
                break;
            case Dir.Down:
                transform.position += _speed * Vector3.down;
                break;
            case Dir.Left:
                transform.position += _speed * Vector3.left;
                break;
            case Dir.Right:
                transform.position += _speed * Vector3.right;
                break;
        }
    }

}

public enum Dir
{
    Up, Down, Left, Right
}
