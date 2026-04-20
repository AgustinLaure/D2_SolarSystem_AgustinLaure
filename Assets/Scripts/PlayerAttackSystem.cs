using UnityEngine;

public class PlayerAttackSystem : MonoBehaviour
{
    [SerializeField] private GameObject cannonPrefab;
    private Cannon cannon;

    [SerializeField] private PlayerController controller;
    [SerializeField] private float shotDamage;
    [SerializeField] private float shotSpeed;

    //In Seconds
    [SerializeField] float shootingCooldown;

    private void Awake()
    {
        cannon = cannonPrefab.GetComponent<Cannon>();
    }
    private void Start()
    {
        cannon.SetCannon(shotSpeed, shotDamage, shootingCooldown);
    }
    private void Update()
    {
        cannon.Tick(controller.IsShoot);

        if (controller.IsShoot)
        {
            cannon.TryShoot(cannon.transform.forward);
        }
    }
}
