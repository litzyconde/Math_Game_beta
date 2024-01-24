using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Estado_bateria : MonoBehaviour
{
    public Variar_valor variable;
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
        if(variable.currentValue <=-2)
        {
            if(!gameover)
            {
                textObject.text = "La bateria se quedo sin energia";
                seguir.SetActive(false);
                if(intento >=5)
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
                anclado=-2;
            }
        }
        else if(variable.currentValue >=5)
        {
            if(!gameover)
            {
                textObject.text = "La bateria esta sobrecargada";
                seguir.SetActive(false);
                if(intento >=5)
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
        else if(variable.currentValue ==4)
        {
            if(!gameover)
            {
                textObject.text = "La bateria esta cargada exitosamente";
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
                textObject.text = "La bateria esta en proceso de carga";
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
