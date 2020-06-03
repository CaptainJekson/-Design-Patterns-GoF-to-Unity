using UnityEngine;

public class MoverToRandomPoint : MonoBehaviour, IMovable
{
    [SerializeField] private float _radius;

    private Vector3 _target;

    private void Awake()
    {
        _target = GetRandomPoint();
    }

    public void Move(float speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, speed * Time.deltaTime);

        if (transform.position == _target)
            _target = GetRandomPoint();
    }

    private Vector3 GetRandomPoint()
    {
        return Random.insideUnitCircle * _radius;
    }
}
