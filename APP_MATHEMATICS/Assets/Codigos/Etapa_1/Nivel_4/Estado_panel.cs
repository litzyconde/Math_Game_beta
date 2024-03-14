using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Estado_panel : MonoBehaviour
{
    public Variar_limpieza variable;
    public GameObject volver;
    public GameObject seguir;
    public GameObject reintentar;
    public TMP_Text textObject; // referencia al objeto de texto TMPro
    private bool gameover;
    private int anclado;
    private int intento;
    // Update is called once per frame
    void Update()
    {
        if(gameover)
        {
            variable.desactivado = true;
        }
        if(variable.currentValue <=-6)
        {
            if(!gameover)
            {
                textObject.text = "El panel solar ha sido obstruido totalmente";
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
                gameover=true;
                anclado=-2;
            }
        }
        else if(variable.currentValue >=6 && variable.currentValue <24)
        {
            if(!gameover)
            {
                textObject.text = "El panel esta aumentando su potencia";
                if(!gameover)
                {
                    seguir.SetActive(true);
                    volver.SetActive(false);
                    reintentar.SetActive(false);
                }
            }
        }
        else if(variable.currentValue > 24)
        {
            if(!gameover)
            {
                textObject.text = "El panel solar se ha roto por mucha manipulacion";
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
                gameover=true;
                anclado=3;
            }
        }
        else if(variable.currentValue ==24)
        {
            if(!gameover)
            {
                textObject.text = "El panel solar ya esta funcionando";
                if(!gameover)
                {
                    seguir.SetActive(true);
                    volver.SetActive(false);
                    reintentar.SetActive(false);
                }
            }
        }
        else 
        {
            if(!gameover)
            {
                textObject.text = "El panel solar necesita 60% de su capacidad para funcionar";
                if(!gameover)
                {
                    volver.SetActive(false);
                    seguir.SetActive(false);
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
