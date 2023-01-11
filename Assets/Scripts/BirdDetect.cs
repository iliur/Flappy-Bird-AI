using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdDetect : MonoBehaviour
{
    
    public float PipeDistance;
    public float UpDistance;
    public float DownDistance;

    public float jumpRange;

    public int a = 0;
    public bool next = false;


    public List<GameObject> pipes = new List<GameObject>();

    void FixedUpdate()
    {

        PipeDistance = pipes[a].gameObject.transform.position.x - gameObject.transform.position.x;
        UpDistance = pipes[a].gameObject.transform.position.y - gameObject.transform.position.y;

        if (PipeDistance < 0)
        {
            next = true;
        }

        if (next)
        {
            a += 1;
            next = false;
        }

        print("Score:" + a);


        
    

    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Pipe"))
        {
            pipes.Add(col.gameObject);
        }
        
    }
}
