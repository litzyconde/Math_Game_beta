using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Variar_angulo : MonoBehaviour
{
    public TMP_Text textObject; // referencia al objeto de texto TMPro
    public int currentValue;
    public GameObject cohete; // Arreglo de GameObjects a activar/desactivar
    public GameObject Propulsor;
    public bool desactivado;
    public Image imagenUI;
    // Start is called before the first frame update
    void Start()
    {
        // Puedes inicializar el estado de los objetos aquí si es necesario
        UpdateObjects();
    }

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
            if (orden == 0 && currentValue < 60)
            {
                currentValue += 10;
            }
            else if (orden == 1 && currentValue > -60)
            {
                currentValue -= 10;
            }
            else if (orden == 2)
            {
                currentValue = currentValue * -1;
            }
            

            // Asegurarse de que currentValue esté siempre entre -5 y 5
            if (currentValue > 60)
            {
                currentValue = 60;
            }
            else if (currentValue < -60)
            {
                currentValue = -60;
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
        RectTransform rectTransform = imagenUI.GetComponent<RectTransform>();
        // Ajusta el ángulo Z del RectTransform
        rectTransform.localEulerAngles = new Vector3(
            rectTransform.localEulerAngles.x,
            rectTransform.localEulerAngles.y,
            currentValue
        );
    }
}