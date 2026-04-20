using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform shootingPoint;
    [SerializeField] Transform bulletContainer;

    private float shotSpeed;
    private float shotDamage;

    //In Seconds
    private float shootingCooldown;

    private float timeSinceShoot = float.MaxValue;

    public void Tick(bool tryShoot)
    {
        HandleCooldown();
    }
    private void Shoot(Vector3 shotDir)
    {
        if (!bulletPrefab)
        {

            Debug.Log("asd");
        }
        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity, bulletContainer);

        bullet.GetComponent<Bullet>().Shoot(shootingPoint.transform.position, shotDir, shotSpeed, shotDamage);

        timeSinceShoot = 0f;
    }
    public void SetCannon(float shotSpeed, float shotDamage, float shootingCooldown)
    {
        this.shotSpeed = shotSpeed;
        this.shotDamage = shotDamage;
        this.shootingCooldown = shootingCooldown;
    }

    private void HandleCooldown()
    {
        timeSinceShoot += Time.deltaTime;
    }

    public void TryShoot(Vector3 shotDir)
    {
        if (CanShoot())
        {
            Shoot(shotDir);
        }
    }

    private bool CanShoot()
    {
        bool canShoot = timeSinceShoot >= shootingCooldown;
        return canShoot;
    }
}
