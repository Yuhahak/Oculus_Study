using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS_Gun : MonoBehaviour
{
    public GameObject bulletPrefab;  //�Ѿ� ������
    public Transform bulletSpawnL;  //�Ѿ��� �����Ǵ� ��ġ
    public Transform bulletSpawnR;  //�Ѿ��� �����Ǵ� ��ġ
    public float bulletSpeed = 20f;  //�Ѿ� �ӵ�
    public float fireRate = 0.5f;  //�Ѿ� ��Ÿ��
    private float nextFire;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
        GameManager.instance.audioManager.Play(AudioManager.AudioType.Shoot, true);
            FireL();
        }
    }

    public void FireL()
    {
        // �Ѿ� ������ ����
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnL.position, bulletSpawnL.rotation);
        GameManager.instance.audioManager.Play(AudioManager.AudioType.Shoot, true);
        // �Ѿ� �߻�
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

        // 2�� �ڿ� �ı�
        Destroy(bullet, 2.0f);
    }

    public void FireR()
    {
        // �Ѿ� ������ ����
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnR.position, bulletSpawnR.rotation);
        GameManager.instance.audioManager.Play(AudioManager.AudioType.Shoot, true);
        // �Ѿ� �߻�
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

        // 2�� �ڿ� �ı�
        Destroy(bullet, 2.0f);
    }
}
