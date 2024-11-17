using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string[] sceneNames;            // Lista de nombres de las escenas
    public KeyCode switchKey = KeyCode.Tab; // Tecla para cambiar de escena
    private int currentSceneIndex = 0;

    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        // Incrementa el índice de la escena
        currentSceneIndex = (currentSceneIndex + 1) % sceneNames.Length;

        // Carga la escena correspondiente
        SceneManager.LoadScene(sceneNames[currentSceneIndex]);
    }
}
