using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Variar_posicion : MonoBehaviour
{
    public TMP_Text textObject; // referencia al objeto de texto TMPro
    public int currentValue;
    public bool desactivado;
    public RectTransform objetoAMover;
    // Start is called before the first frame update
  


    // Update is called once per frame
    void Update()
    {
        if(!desactivado)
        {
            textObject.text = "x = " + currentValue.ToString();
        }
    }

    public void valorsiguiente(int orden)
    {
        if(!desactivado)
        {
            if (orden == 0 && currentValue < 7)
            {
                currentValue += 1;
            }
            else if (orden == 1 && currentValue > -11)
            {
                currentValue -= 1;
            }
            else if (orden == 2)
            {
                currentValue = currentValue * -1;
            }
            

            // Asegurarse de que currentValue esté siempre entre -5 y 5
            if (currentValue > 7)
            {
                currentValue = 7;
            }
            else if (currentValue < -11)
            {
                currentValue = -11;
            }

            // Actualizar el estado de los objetos según el nuevo valor
            UpdateObjects();
        }
        if (orden == 3)
        {
            currentValue = 0;
            UpdateObjects();

        }
    }

    void UpdateObjects()
    {
        objetoAMover.localPosition = new Vector3 (0, 350+(currentValue*-75), 0);
    }
}