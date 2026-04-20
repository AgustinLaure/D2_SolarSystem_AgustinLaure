using UnityEngine;

public class Bullet : Projectile
{
    private void Awake()
    {
        maxDistance = 1000f;
        maxTimeAlive = 10f;
    }

    protected override void Update()
    {
        base.Update();
    }

    public void Shoot(Vector3 shootingPos, Vector3 direction, float speed, float damage)
    {
        startPos = shootingPos;
        this.speed = speed;
        this.damage = damage;
        this.direction = direction;
    }
}
