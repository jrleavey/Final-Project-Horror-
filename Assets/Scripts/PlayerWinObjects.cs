using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWinObjects : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blanket"))
        {
            SceneManager.LoadScene("HubLevel");
        }
        if (other.gameObject.CompareTag("Teddy"))
        {
            SceneManager.LoadScene("HubLevel");
        }
        if (other.gameObject.CompareTag("StoryBook"))
        {
            SceneManager.LoadScene("HubLevel");
        }
    }
}
