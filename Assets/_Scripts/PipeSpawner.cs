using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float spawnRate = 5;
    [SerializeField] float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Instantiate(pipe, new Vector3(transform.position.x,transform.position.y + Random.Range(-10.0f, 10.0f),transform.position.z), transform.rotation);
            timer = 0;
        }
    }
}
