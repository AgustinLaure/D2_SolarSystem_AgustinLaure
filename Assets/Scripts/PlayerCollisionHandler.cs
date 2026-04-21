using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Planet"))
        {
            OnPlanetCollision();
        }

        if (collision.gameObject.CompareTag("Sun"))
        {
            OnPlanetCollision();
        }
    }
    private void OnPlanetCollision()
    {
        Destroy(gameObject);
    }

    private void OnSunCollision()
    {
        Destroy(gameObject);
    }
}
