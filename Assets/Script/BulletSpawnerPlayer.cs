using UnityEngine;
using UnityEngine.UI;

public class BulletSpawnerPlayer : BulletSpawner
{
    public Image crosshair;
    public AudioSource gunSound;
    private float targetCrosshairRotation;
    private float angleVelocity;

    // Start is called before the first frame update
    void Start()
    {
        angleVelocity = -90f / GunCooldown;
        targetCrosshairRotation = crosshair.transform.rotation.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        gunSound.pitch = Time.timeScale;

        if (Input.GetMouseButtonDown(0) && Time.time > passedCooldownTime)
        {
            Vector3 bulletSpawnPosition = bulletSpawnPoint.position;
            bulletSpawnPosition += bulletSpawnPoint.forward; // offset bullet from camera, so playermodel is not hit
            spawnBullet(bulletSpawnPosition, bulletSpawnPoint.rotation);
            targetCrosshairRotation = crosshair.transform.rotation.eulerAngles.z + -90f; // turn crosshair clockwise
            gunSound.Play();
        }

        Debug.Log("z: " + crosshair.transform.rotation.eulerAngles.z + " target: " + targetCrosshairRotation);

        if (crosshair.transform.rotation.eulerAngles.z >= targetCrosshairRotation)
        //if (Time.time < passedCooldownTime)
        {
            float newCrosshairRotation = crosshair.transform.rotation.eulerAngles.z + (angleVelocity * Time.deltaTime);
            crosshair.transform.rotation = Quaternion.Euler(0, 0, newCrosshairRotation);
            //if (crosshair.transform.rotation.z <= targetCrosshairRotation)
            //{
            //    Debug.Log("cooldown");

            //    GameObject newCrosshair = crosshair.gameObject;
            //    //newCrosshair.transform.rotation.eulerAngles = Vector3.zero;

            //    Destroy(crosshair.gameObject);
            //    crosshair = newCrosshair.GetComponent<Image>();
            //}
        }
    }
}
