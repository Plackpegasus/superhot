using UnityEngine;
using UnityEngine.UI;

public class BulletSpawnerPlayer : BulletSpawner
{
    public Image crosshair;
    private float targetCrosshairRotation = -90f;

    // Start is called before the first frame update
    void Start()
    {
        targetCrosshairRotation = targetCrosshairRotation / gunCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 bulletSpawnPosition = bulletSpawnPoint.position;
            bulletSpawnPosition += bulletSpawnPoint.forward; // offset bullet from camera, so playermodel is not hit
            spawnBullet(bulletSpawnPosition, bulletSpawnPoint.rotation);
        }

        if (Time.time < passedCooldownTime)
        {
            float newCrosshairRotation = crosshair.transform.rotation.z + (targetCrosshairRotation * Time.time);
            crosshair.transform.rotation = Quaternion.Euler(0, 0, newCrosshairRotation);
        }
    }
}
