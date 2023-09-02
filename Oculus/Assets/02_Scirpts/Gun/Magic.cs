using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public Camera cam;
    public GameObject magicPrefab;
    public Transform LPoint, RPoint;
    public float magicSpeed;
    public float fireRate = 4f;
    public float arcRange = 1f;

    private Vector3 destinattion;
    private bool leftHand;
    private float timeToFire;

    void Update()
    {
        // 0.5초 간격으로 총알을 발사 할 수 있음
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time > timeToFire)
        {
            timeToFire = Time.time + fireRate;
            MagicShootL();
        }

        if (Input.GetKeyDown(KeyCode.Mouse1) && Time.time > timeToFire)
        {
            timeToFire = Time.time + fireRate;
            MagicShootR();
        }
    }

    void MagicShootL()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
            destinattion = hit.point;
        else
            destinattion = ray.GetPoint(1000);

        magicPrefabCreate(LPoint);
    }

    void MagicShootR()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
            destinattion = hit.point;
        else
            destinattion = ray.GetPoint(1000);

        magicPrefabCreate(RPoint);
    }

    void magicPrefabCreate(Transform firePoint)
    {
        var magicObj = Instantiate(magicPrefab, firePoint.position, Quaternion.identity) as GameObject;
        magicObj.GetComponent<Rigidbody>().velocity = (destinattion - firePoint.position).normalized * magicSpeed;

        iTween.PunchPosition(magicObj, new Vector3(Random.Range(-arcRange, arcRange), Random.Range(-arcRange, arcRange), 0), Random.Range(0.5f, 2));
    }
}
