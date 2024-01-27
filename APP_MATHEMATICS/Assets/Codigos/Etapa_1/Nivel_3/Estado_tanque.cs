using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Estado_tanque : MonoBehaviour
{
    public Variar_cantidad variable;
    public GameObject volver;
    public GameObject seguir;
    public GameObject reintentar;
    public TMP_Text textObject; // referencia al objeto de texto TMPro
    private bool gameover;
    public Image imagenUI;
    private int anclado;
    private int intento;
    // Update is called once per frame
    void Update()
    {
        if(gameover)
        {
            variable.desactivado = true;
        }
        if(variable.currentValue <=-500)
        {
            if(!gameover)
            {
                textObject.text = "El tanque se vacio totalmente";
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
        else if(variable.currentValue >=400)
        {
            if(!gameover)
            {
                textObject.text = "El tanque ha sobrepasado su limite";
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
                imagenUI.color = Color.red;
                gameover=true;
                anclado=3;
            }
        }
        else if(variable.currentValue ==300)
        {
            if(!gameover)
            {
                textObject.text = "El tanque esta abastecido correctamente";
                if(!gameover)
                {
                    seguir.SetActive(true);
                    volver.SetActive(false);
                    reintentar.SetActive(false);
                }
                imagenUI.color = Color.green;
            }
        }
        else 
        {
            if(!gameover)
            {
                textObject.text = "Llene el tanque de gasolina al nivel requerido";
                if(!gameover)
                {
                    volver.SetActive(false);
                    seguir.SetActive(false);
                    reintentar.SetActive(false);
                }
                imagenUI.color = Color.yellow;
            }
        }

    }
    public void resetgame()
    {
        gameover=false;
        variable.desactivado=false;
    }
}
