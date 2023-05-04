using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZ : MonoBehaviour
{

    public float speed = 1f;
    public float leftEdge = 10f;
    public float rightEdge = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.z < -rightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.z > leftEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
}
