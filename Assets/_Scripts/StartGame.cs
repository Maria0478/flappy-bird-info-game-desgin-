using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Added for scene management

public class StartGame : MonoBehaviour
{
    public void change()
    {
        PipeSpawner.pipeSpawnerPaused = false;
        PipeMovementScript.pipeMovementPaused = false;
        BirdScript.birdMovementPaused = false;
        SceneManager.LoadScene("flappy bird game");

    }
}
