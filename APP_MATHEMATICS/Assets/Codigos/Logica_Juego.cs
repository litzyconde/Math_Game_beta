using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Logica_Juego : MonoBehaviour
{
    public void CambiarEscena( GameObject Escenasiguiente)
    {
        //SceneManager.LoadScene(1);
        Escenasiguiente.SetActive(true);
        gameObject.SetActive(false);
    }
}
