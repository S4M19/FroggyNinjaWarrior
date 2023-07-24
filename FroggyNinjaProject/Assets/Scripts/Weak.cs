using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weak : MonoBehaviour
{
    AudioSource sonido;
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sonido.Play();
            Destroy(gameObject);
        }
    }
}
