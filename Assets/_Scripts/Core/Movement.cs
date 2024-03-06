using UnityEngine;

public class Movement : MonoBehaviour
{
    internal float _speed = 1.0f;

    public void Move(Dir dir)
    {
        switch(dir)
        {
            case Dir.Up:
                transform.position += _speed * Time.deltaTime * Vector3.up;
                break;
            case Dir.Down:
                transform.position += _speed * Time.deltaTime * Vector3.down;
                break;
            case Dir.Left:
                transform.position += _speed * Time.deltaTime * Vector3.left;
                break;
            case Dir.Right:
                transform.position += _speed * Time.deltaTime * Vector3.right;
                break;
        }
    }

}

public enum Dir
{
    Up, Down, Left, Right, None
}

public class DirUtils
{
    public static Dir GetDir(Vector2 dir)
    {
        if (dir.x == 0 && dir.y > 0){
            return Dir.Up;
        }
        if (dir.x == 0 && dir.y < 0){
            return Dir.Down;
        }
        if (dir.x < 0 && dir.y == 0){
            return Dir.Left;
        }
        if (dir.x > 0 && dir.y == 0){
            return Dir.Right;
        }
        return Dir.None;
    }
}
