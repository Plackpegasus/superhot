using UnityEngine;

public class BulletSpawnerEnemy : BulletSpawner
{
    private GameObject player;

    void Start() 
    {
        player = GameObject.FindWithTag("Player");

        // enemies should not start to shoot straight away & all at once
        passedCooldownTime = Time.time + Random.Range(GunCooldown, GunCooldown * 2);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rayOrigin = bulletSpawnPoint.position;
        Vector3 rayDirection = player.transform.position - rayOrigin;
        RaycastHit hit;

        Physics.Raycast(rayOrigin, rayDirection, out hit, Mathf.Infinity);

        if (hit.collider.tag == "Player")
        {
            float rayHitAngle = 180 - Vector3.Angle(rayDirection, hit.normal);
            Quaternion parentRotation = GetComponentInParent<Transform>().rotation;

            // hit.normal is 90° to surface, if enemy position too high bullet angle is falsified because of capsule geometry
            Quaternion bulletSpawnRotation = Quaternion.Euler(rayHitAngle, parentRotation.eulerAngles.y, parentRotation.eulerAngles.z);
            spawnBullet(bulletSpawnPoint.position, bulletSpawnRotation);

            // visual ray for debugging
            Debug.DrawRay(rayOrigin, rayDirection * hit.distance, Color.red);
        } 
    }
}
