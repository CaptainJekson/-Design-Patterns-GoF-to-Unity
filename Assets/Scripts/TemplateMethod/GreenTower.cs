using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTower : Tower
{
    [SerializeField] private float _step;

    protected override void GenerateBullet()
    {
        float step = _step;

        for (int i = 0; i <= _quantityGenerateBullets; i++)
        {
            Vector3 position = new Vector3(transform.position.x + step, transform.position.y, transform.position.z);
            Instantiate(_bullet, transform.position + position, Quaternion.identity);

            step += _step;
        }
    }
}
