using UnityEngine;

public class BulletSpawnerEnemy : BulletSpawner
{
    void Start() 
    {
        // enemies should not start to shoot straight away & all at once
        passedCooldownTime = Time.time + Random.Range(gunCooldown, gunCooldown * 2);
    }

    // Update is called once per frame
    void Update()
    {
        spawnBullet();
    }
}
