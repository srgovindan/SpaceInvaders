using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

//func alt enter for disabling stuff

public class DestroyOnCollision : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D other)
    // When Enemy collides with things that are not walls, they destroy them
    {
        if (!other.gameObject.CompareTag("Wall"))
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Destroy(other.gameObject);
                SceneManager.LoadScene(0);
            }
            Destroy(other.gameObject);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    // When enemy hits a bullet, enemy and bullet are destroyed 
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            
        }
    }
}

