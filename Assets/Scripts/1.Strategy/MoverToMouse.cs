using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverToMouse : MonoBehaviour, IMovable
{
    public void Move(float speed)
    {
        Vector2 mousePositionWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = Vector3.MoveTowards(transform.position, mousePositionWorld, speed * Time.deltaTime);
    }
}
