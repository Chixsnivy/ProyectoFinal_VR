using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void NieveBtn()
    {
        SceneManager.LoadScene("Entorno Nieve");
    }

    public void BosqueBtn()
    {
        SceneManager.LoadScene("Entorno Bosque");
    }

    public void EspecialBtn()
    {
        SceneManager.LoadScene("Entorno Especial");
    }
}
