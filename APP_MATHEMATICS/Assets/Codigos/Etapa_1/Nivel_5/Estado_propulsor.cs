using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Estado_propulsor : MonoBehaviour
{
    public Variar_potencia variable;
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
        if(variable.currentValue <= -2)
        {
            if(!gameover)
            {
                textObject.text = "El propulsor se apago totalmente y dejo la nave en la deriva";
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
        else if(variable.currentValue > -2 && variable.currentValue < 2 )
        {
            if(!gameover)
            {
                textObject.text = "El propulsor esta empezando a encenderse";
                if(!gameover)
                {
                    seguir.SetActive(false);
                    volver.SetActive(false);
                    reintentar.SetActive(false);
                }
            }
        }
        else if(variable.currentValue >= 3)
        {
            if(!gameover)
            {
                textObject.text = "El propulsor se sobrecargo y explotó";
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
        else if(variable.currentValue ==2)
        {
            if(!gameover)
            {
                textObject.text = "La nave esta lista para ir al planeta";
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
                textObject.text = "El propulsor necesita tener una potencial adecuada para mover la nave";
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
