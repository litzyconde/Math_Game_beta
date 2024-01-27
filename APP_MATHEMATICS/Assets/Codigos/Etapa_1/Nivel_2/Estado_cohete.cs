using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Estado_cohete : MonoBehaviour
{
    public Variar_angulo variable;
    public GameObject volver;
    public GameObject seguir;
    public GameObject reintentar;
    public TMP_Text textObject; // referencia al objeto de texto TMPro
    private bool gameover;
    public GameObject propulsor;
    private int anclado;
    private int intento;
    // Update is called once per frame
    void Update()
    {
        if(gameover)
        {
            variable.desactivado = true;
        }
        if(variable.currentValue <=-40)
        {
            if(!gameover)
            {
                textObject.text = "La nave se dirije a una estrella, perdiste";
                seguir.SetActive(false);
                if(intento >=3)
                {
                    volver.SetActive(true);
                }
                else
                {
                    reintentar.SetActive(true);
                    intento++;
                }
                propulsor.SetActive(true);
                gameover=true;
                anclado=-2;
            }
        }
        else if(variable.currentValue >=50)
        {
            if(!gameover)
            {
                textObject.text = "La nave se perdera en el espacio";
                seguir.SetActive(false);
                if(intento >=3)
                {
                    volver.SetActive(true);
                    intento=0;
                }
                else
                {
                    reintentar.SetActive(true);
                    intento++;
                }
                propulsor.SetActive(true);
                gameover=true;
                anclado=3;
            }
        }
        else if(variable.currentValue ==40)
        {
            if(!gameover)
            {
                textObject.text = "La nave se dirige a Orión";
                if(!gameover)
                {
                    seguir.SetActive(true);
                    volver.SetActive(false);
                    propulsor.SetActive(true);
                    reintentar.SetActive(false);
                }
            }
        }
        else 
        {
            if(!gameover)
            {
                textObject.text = "Ajuste la direccion de la nave";
                if(!gameover)
                {
                    volver.SetActive(false);
                    seguir.SetActive(false);
                    propulsor.SetActive(false);
                    reintentar.SetActive(false);
                }
            }
        }

    }
    public void resetgame()
    {
        gameover=false;
        variable.desactivado=false;
    }
}
