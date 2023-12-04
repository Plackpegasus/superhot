using UnityEngine;

public class BulletSpawnerEnemy : BulletSpawner
{
    void Start() 
    {
        // enemy should not start to shooting straight away
        passedCooldownTime = Time.time + gunCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        spawnBullet();
    }
}
