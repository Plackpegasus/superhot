using UnityEngine;

public abstract class BulletSpawner : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;

    [SerializeField]
    protected float gunCooldown = 3f;
    protected float passedCooldownTime;

    protected void spawnBullet(Vector3 spawnPosition, Quaternion spawnRotation) {
        if (Time.time > passedCooldownTime) 
        {
            Instantiate(bulletPrefab, spawnPosition, spawnRotation);
            passedCooldownTime = Time.time + gunCooldown;
        }
    }
}
