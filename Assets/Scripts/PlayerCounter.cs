using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCounter : MonoBehaviour
{

    public GameObject[] birds;

    public GameObject Bird;

    public int birdCount;

    public float distY;
    public float distX;

    public GameObject[] lastBird;



    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(Bird, gameObject.transform);
        }

        birds = GameObject.FindGameObjectsWithTag("Bird");
    }

    // Update is called once per frame
    void Update()
    {


        birdCount = 0;
        for (int n = 0; n < 10; n++)
        {
            if (birds[n] != null)       
            {
                birdCount += 1;
            }
        }

        if (birdCount == 1)
        {
            lastBird = GameObject.FindGameObjectsWithTag("Bird");
            distY = lastBird[0].GetComponent<BirdMovement>().randomJump;
            distX = lastBird[0].GetComponent<BirdMovement>().randomRun;
            PlayerPrefs.SetFloat("DistY", distY);
            PlayerPrefs.SetFloat("DistX", distX);
        }

        if (birdCount <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
