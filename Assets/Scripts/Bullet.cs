using UnityEngine;

public class Bullet : Projectile
{
    [SerializeField] float speed;

    private void Awake()
    {
        projSpeed = speed;
        maxDistance = 1000f;
        maxTimeAlive = 40f;
    }

    private void Update()
    {
        ProjectileUpdate();
    }

    public void Set(Vector3 initialPos, float speed, Vector3 direction)
    {
        startPos = initialPos;
        projSpeed = speed;
        projDirection = direction;
    }
}
