using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    Rigidbody2D rb;
    public float power = 1;

    BirdDetect birdDetect;
    public GameObject detect;

    public float randomJump;
    public float randomRun;

    // Start is called before the first frame update
    void Start()
    {
        birdDetect = detect.GetComponent<BirdDetect>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        randomJump = Random.Range(PlayerPrefs.GetFloat("DistY") - 0.5f, PlayerPrefs.GetFloat("DistY") + 0.5f);
        randomRun = Random.Range(PlayerPrefs.GetFloat("DistX") - 0.5f, PlayerPrefs.GetFloat("DistX") + 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (birdDetect.UpDistance > randomJump && birdDetect.PipeDistance < randomRun)
        {
            rb.velocity = Vector2.up * power;
        }



        if (Input.GetMouseButtonDown(0))
        {
            // rb.AddForce(transform.up * power);
            rb.velocity = Vector2.up * power;
        }


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Pipe") || col.gameObject.tag.Equals("PipeCollide"))
        {
            Destroy(gameObject);
        }
    }
}
