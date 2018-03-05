using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class Finish : MonoBehaviour
    {
        public AudioSource trumpet;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                trumpet = GetComponent<AudioSource>();
                trumpet.Play();
                //new WaitForSeconds(5);
                //SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            }
        }
    }
}
