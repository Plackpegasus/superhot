using UnityEngine;
using UnityEngine.UI;

public class BulletSpawnerPlayer : BulletSpawner
{
    public Image crosshair;
    private float crosshairRotation = 90f;

    // Start is called before the first frame update
    void Start()
    {
        crosshairRotation = crosshairRotation / gunCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 bulletSpawnPosition = bulletSpawnPoint.position;
            bulletSpawnPosition += bulletSpawnPoint.forward; // offset bullet from camera, so playermodel is not hit
            spawnBullet(bulletSpawnPosition, bulletSpawnPoint.rotation);

            // TODO: gun crosshair spin
            // crosshair.rectTransform.rotation += Quaternion.Euler(new Vector3(0,0,crosshairRotation));
        }
    }
}
