using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS_Gun : MonoBehaviour
{
    public GameObject bulletPrefab;  //ÃÑ¾Ë ÇÁ¸®ÆÕ
    public Transform bulletSpawn;  //ÃÑ¾ËÀÌ »ý¼ºµÇ´Â À§Ä¡
    public float bulletSpeed = 20f;  //ÃÑ¾Ë ¼Óµµ
    public float fireRate = 0.5f;  //ÃÑ¾Ë ÄðÅ¸ÀÓ
    private float nextFire;

    void Update()
    {
        // 0.5ÃÊ °£°ÝÀ¸·Î ÃÑ¾ËÀ» ¹ß»ç ÇÒ ¼ö ÀÖÀ½
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Fire();
        }
    }

    void Fire()
    {
        // ÃÑ¾Ë ÇÁ¸®ÆÕ »ý¼º
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        // ÃÑ¾Ë ¹ß»ç
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

        // 2ÃÊ µÚ¿¡ ÆÄ±«
        Destroy(bullet, 2.0f);
    }
}
