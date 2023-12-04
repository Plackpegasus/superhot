using UnityEngine;

public abstract class BulletSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bulletPrefab;

    [SerializeField]
    protected float gunCooldown = 3f;
    protected float passedCooldownTime;

    protected void spawnBullet() {
        if (Time.time > passedCooldownTime) 
        {
            Vector3 spawnPosition = spawnPoint.position + spawnPoint.forward;
            Instantiate(bulletPrefab, spawnPosition, spawnPoint.rotation);

            passedCooldownTime = Time.time + gunCooldown;
        }
    }
}
