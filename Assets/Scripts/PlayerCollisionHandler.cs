using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Planet"))
        {
            OnPlanetCollision();
        }
    }
    private void OnPlanetCollision()
    {
        Destroy(gameObject);
    }
}
