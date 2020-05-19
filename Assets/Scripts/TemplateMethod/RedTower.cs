using UnityEngine;

public class RedTower : Tower
{
    [SerializeField] private float _radius;
    [SerializeField] private float _angle;

    protected override void GenerateBullet()
    {
        Vector3 point = transform.position;
        float angle = _angle * Mathf.Deg2Rad;

        for (int i = 0; i <= _quantityGenerateBullets; i++)
        {
            float x = transform.position.x + Mathf.Sin(angle / _quantityGenerateBullets * i) * _radius;
            float y = transform.position.y + Mathf.Cos(angle / _quantityGenerateBullets * i) * _radius;

            point.x = x;
            point.y = y;

            Instantiate(_bullet, point, Quaternion.identity);
        }
    }
}
