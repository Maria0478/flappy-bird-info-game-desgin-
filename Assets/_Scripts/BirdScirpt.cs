using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public static bool birdMovementPaused = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!birdMovementPaused)
        {
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                myRigidbody.velocity = Vector2.up * 10;
            }
        }
    }

    // This method is called when the GameObject collides with another GameObject
    void OnCollisionEnter2D(Collision2D collision)
    {
        PipeSpawner.pipeSpawnerPaused = true;
        PipeMovementScript.pipeMovementPaused = true;
        birdMovementPaused = true;
        StartCoroutine(DestroyPipes());
        // Find all GameObjects tagged as "Pipe"

    }
    IEnumerator DestroyPipes()
    {

        yield return new WaitForSeconds(2);

        GameObject[] pipes = GameObject.FindGameObjectsWithTag("Pipe");

        // Loop through the array and destroy each pipe
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i]);
        }

        Destroy(gameObject);

    }

}
