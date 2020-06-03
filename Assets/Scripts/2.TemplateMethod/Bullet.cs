using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _lifeTime;

    private void Awake()
    {
        Destroy(gameObject, _lifeTime);
    }
}
