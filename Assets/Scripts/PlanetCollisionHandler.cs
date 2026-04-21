using UnityEngine;

public class PlanetCollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            OnBulletCollision();
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            OnPlayerCollision();
        }
    }

    private void OnBulletCollision()
    {
        Destroy(gameObject);
    }

    private void OnPlayerCollision()
    {

    }
}
