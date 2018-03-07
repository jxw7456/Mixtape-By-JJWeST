using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoints : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.tag == "Player")
        {
            SceneManager.CreateScene("checkpoint");
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("checkpoint"));
            Debug.Log("Checkpoint Created");
        }*/
    }
}
