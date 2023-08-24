using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollect : MonoBehaviour
{
    private int Score = 0;
    [SerializeField] private Text ScoreCount;
    [SerializeField] private AudioSource CollectSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            CollectSound.Play();
            Destroy(collision.gameObject);
            Score++;
            ScoreCount.text = "Score: " + Score;
        }
    }
}