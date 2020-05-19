using UnityEngine;

public class MoverForward : MonoBehaviour, IMovable
{
    public void Move(float speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.right, speed * Time.deltaTime);
    }
}
