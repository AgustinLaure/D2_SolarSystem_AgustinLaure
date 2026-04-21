using UnityEngine;
using UnityEngine.Rendering;

public class Projectile : MonoBehaviour
{
    protected Vector3 startPos;

    protected float speed;
    protected Vector3 direction;
    protected float damage;

    protected float maxDistance;
    protected float maxTimeAlive;

    private float currentDistance = 0f;
    private float currentTimeAlive = 0f;

    private void Awake()
    {
        transform.position = startPos;
    }
    protected virtual void Update() 
    {
        Move();
        CheckLifespan();
    }
    protected void Move()
    {
        transform.position += direction * (speed * Time.deltaTime);

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

