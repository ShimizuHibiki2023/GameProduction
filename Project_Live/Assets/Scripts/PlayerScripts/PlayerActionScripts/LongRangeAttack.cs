using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//作成者：桑原

public class LongRangeAttack : MonoBehaviour
{
    [Header("発射する弾")]
    [SerializeField] GameObject bulletPrefab;
    [Header("発射位置")]
    [SerializeField] Transform shotPos;
    [Header("弾の速度")]
    [SerializeField] float bulletSpeed;
    [Header("再発射までの間隔")]
    [SerializeField] float shotInterval = 0.5f;

    float timeSinceLastShot = 0f;

    void Update()
    {
        timeSinceLastShot += Time.deltaTime;
    }

    public void ShotBullet()
    {
        if (timeSinceLastShot < shotInterval) return;

        GameObject bullet = Instantiate(bulletPrefab, shotPos.transform.position, shotPos.transform.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = shotPos.forward * bulletSpeed;

        timeSinceLastShot = 0f;
    }
}
