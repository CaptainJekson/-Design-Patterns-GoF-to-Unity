using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _lifeTime;

    private void Awake()
    {
        Destroy(gameObject, _lifeTime);
    }
}
