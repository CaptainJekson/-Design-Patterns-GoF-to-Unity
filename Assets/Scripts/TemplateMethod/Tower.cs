using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    [SerializeField] protected Bullet _bullet;
    [SerializeField] protected int _quantityGenerateBullets;
    [SerializeField] private int _ammunation;

    private bool CanAttack => _ammunation > 0;

    private void OnMouseDown()
    {
        ToAttack();
    }

    protected void ToAttack()
    {
        if(CanAttack)
        {
            --_ammunation;
            GenerateBullet();
        }
    }

    protected abstract void GenerateBullet();
}
