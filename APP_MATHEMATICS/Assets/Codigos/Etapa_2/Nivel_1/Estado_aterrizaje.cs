using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Estado_aterrizaje : MonoBehaviour
{
    public Variar_posicion variable;
    public GameObject volver;
    public GameObject seguir;
    public GameObject reintentar;
    public TMP_Text textObject; // referencia al objeto de texto TMPro
    private bool gameover;
    private int anclado;
    private int intento;
    public GameObject humo;
    public GameObject prop;
    // Update is called once per frame
    void Update()
    {
        if(gameover)
        {
            variable.desactivado = true;
        }
        if(variable.currentValue < -10)
        {
            if(!gameover)
            {
                textObject.text = "La nave se fue del planeta";
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
        else if(variable.currentValue > 5)
        {
            if(!gameover)
            {
                textObject.text = "La nave se estrello con el planeta";
                seguir.SetActive(false);
                humo.SetActive(true);
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
        else if(variable.currentValue ==5)
        {
            if(!gameover)
            {
                textObject.text = "La nave ya ha aterrizado y esta lista para la operación";
                humo.SetActive(false);
                prop.SetActive(false);
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
                textObject.text = "El cohete necesita aterrizar";
                prop.SetActive(true);
                humo.SetActive(false);
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
