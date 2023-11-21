using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Variar_valor : MonoBehaviour
{
    public TMP_Text textObject; // referencia al objeto de texto TMPro
    public int currentValue;
    public GameObject[] objectsToToggle; // Arreglo de GameObjects a activar/desactivar
    public Color normalColor = Color.green; // Color normal de los objetos
    public Color warningColor = Color.red; // Color cuando currentValue es mayor a 3
    public bool desactivado;
    private Image img;

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
            // Cambiar el color de los objetos si currentValue es mayor a 3
            foreach (GameObject obj in objectsToToggle)
            {
                img = obj.GetComponent<Image>();
                if (img != null)
                {
                    img.color = currentValue > 4 ? warningColor : normalColor;
                }
            }
        }
    }

    public void valorsiguiente(int orden)
    {
        if(!desactivado)
        {
            if (orden == 0 && currentValue < 5)
            {
                currentValue++;
            }
            else if (orden == 1 && currentValue > -5)
            {
                currentValue--;
            }
            else if (orden == 2)
            {
                currentValue = currentValue * -1;
            }
            

            // Asegurarse de que currentValue esté siempre entre -5 y 5
            if (currentValue > 5)
            {
                currentValue = 5;
            }
            else if (currentValue < -5)
            {
                currentValue = -5;
            }

            // Actualizar el estado de los objetos según el nuevo valor
            UpdateObjects();
        }
        if (orden == 3)
        {
            currentValue = 0;
            for (int i = 0; i < objectsToToggle.Length; i++)
            {
                if(currentValue>=-2)
                {
                    objectsToToggle[i].SetActive(i < Mathf.Abs(currentValue+2));
                }
            }
            img.color = normalColor;
        }
    }

    void UpdateObjects()
    {
        // Activar/desactivar objetos según el valor de currentValue
        for (int i = 0; i < objectsToToggle.Length; i++)
        {
            if(currentValue>=-2)
            {
                objectsToToggle[i].SetActive(i < Mathf.Abs(currentValue+2));
            }
        }
    }
}
