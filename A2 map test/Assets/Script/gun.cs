using System.Collections;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public Transform rayVector;

    void Update()
    {
        Debug.DrawLine(bulletSpawn.position, rayVector.position, Color.red);

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6.0f;

        Destroy(bullet, 2f);
    }
}
