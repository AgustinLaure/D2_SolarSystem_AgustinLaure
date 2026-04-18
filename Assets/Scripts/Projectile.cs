using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 startPos;
    protected float projSpeed;
    protected Vector3 projDirection;
    protected float maxDistance;
    protected float maxTimeAlive;

    private float currentDistance = 0f;
    private float currentTimeAlive = 0f;

    private void Awake()
    {
        transform.position = startPos;
    }
    protected void Update()
    {
        Move();
        CheckLifespan();
    }
    protected void Move()
    {
        transform.position += projDirection * (projSpeed * Time.deltaTime);

        currentDistance = (transform.position - startPos).magnitude;
    }

    private void CheckLifespan()
    {
        currentTimeAlive += Time.deltaTime;

        if (currentDistance >= maxDistance || currentTimeAlive >= maxTimeAlive)
        {
            Destroy(gameObject);
        }
    }
}

