using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float moveSpeed = 10;
    [SerializeField] float deadZone = -45;
    public static bool pipeMovementPaused = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!pipeMovementPaused)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
            if (transform.position.x <deadZone)
            {
                Destroy(gameObject);
            }
        }
    }
}
