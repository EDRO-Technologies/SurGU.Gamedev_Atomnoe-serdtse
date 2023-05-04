using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float timeStart = 5;
    public float timeContinue = 5;
    public Transform barrelLocation;
    public GameObject bulletPrefab;
    public float bulletTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;

        if (timeStart <= 0)
        {
            timeStart = timeContinue;
            Fire();
            Debug.Log("FIRE!");
        }
    }

    void Fire()
    {
        GameObject bullet;
        bullet = Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation);
        Destroy(bullet, bulletTime);
    }
}
