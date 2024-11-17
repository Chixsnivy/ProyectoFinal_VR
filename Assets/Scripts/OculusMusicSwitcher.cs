using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class OculusMusicSwitcher : MonoBehaviour
{
    public AudioClip[] songs;         // Lista de canciones
    public InputActionProperty switchAction;  // Acci�n de entrada para cambiar de canci�n
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
        if (OVRInput.Get(OVRInput.Button.One))
        {
            ChangeSong();
        }

        // Comprueba si el bot�n asignado ha sido presionado
       /* if (switchAction.action.WasPressedThisFrame())
        {
            ChangeSong();
        }   */
    }

    void ChangeSong()
    {
        // Cambia al siguiente �ndice de canci�n
        currentSongIndex = (currentSongIndex + 1) % songs.Length;
        audioSource.clip = songs[currentSongIndex];
        audioSource.Play();
    }
}
