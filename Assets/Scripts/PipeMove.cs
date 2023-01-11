using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 5;

    public float deathTimer = 20f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector2(transform.position.x - speed, transform.position.y);
        if (deathTimer < 0)
        {
            Destroy(gameObject);
        }
    }
}
