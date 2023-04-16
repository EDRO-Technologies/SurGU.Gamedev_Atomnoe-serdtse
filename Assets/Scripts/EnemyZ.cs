using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyZ : MonoBehaviour
{

    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public Animator anim;

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

        if (pos.z < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.z > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }


        if (pos.magnitude == 0f)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
    }
}
