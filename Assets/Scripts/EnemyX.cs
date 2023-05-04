using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
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
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > rightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
}
