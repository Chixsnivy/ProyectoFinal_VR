using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip[] songs;      // Lista de canciones
    public KeyCode switchKey = KeyCode.Backspace; // Tecla para cambiar de canción
    private AudioSource audioSource;
    private int currentSongIndex = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (songs.Length > 0)
        {
            audioSource.clip = songs[currentSongIndex];
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("No se han asignado canciones en la lista.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            ChangeSong();
        }
    }

    void ChangeSong()
    {
        // Cambia al siguiente índice de canción
        currentSongIndex = (currentSongIndex + 1) % songs.Length;
        audioSource.clip = songs[currentSongIndex];
        audioSource.Play();
    }
}
