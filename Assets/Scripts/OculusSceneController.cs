using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class OculusSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            SceneManager.LoadScene("Entorno Bosque");
        }

        if (OVRInput.Get(OVRInput.Button.Three))
        {
            SceneManager.LoadScene("Entorno Desierto");
        }

        if (OVRInput.Get(OVRInput.Button.Four))
        {
            SceneManager.LoadScene("Entorno Nieve");
        }
    }
}
