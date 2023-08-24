using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] private AudioSource Finishsoundeffect;
    private bool LevelComplete = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "MaskDudePlayer" && !LevelComplete)
        {
            Finishsoundeffect.Play();
            LevelComplete = true;
            Invoke("CompleteLevel", 2f);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }
}
