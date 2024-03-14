using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Variar_potencia : MonoBehaviour
{
    public TMP_Text textObject; // referencia al objeto de texto TMPro
    public int currentValue;
    public bool desactivado;
    public List<GameObject> listaDeObjetos;
    public GameObject padreAutomatico;
    // Start is called before the first frame update
    void Start()
    {
        // Puedes inicializar el estado de los objetos aquí si es necesario
        UpdateObjects();
        foreach (Transform hijo in padreAutomatico.transform)
        {
            listaDeObjetos.Add(hijo.gameObject);
        }
        
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
            if (orden == 0 && currentValue < 24)
            {
                currentValue += 1;
            }
            else if (orden == 1 && currentValue > -6)
            {
                currentValue -= 1;
            }
            else if (orden == 2)
            {
                currentValue = currentValue * -1;
            }
            

            // Asegurarse de que currentValue esté siempre entre -5 y 5
            if (currentValue > 24)
            {
                currentValue = 24;
            }
            else if (currentValue < -6)
            {
                currentValue = -6;
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
        int elementosActivados = 2+currentValue;

        for (int i = 0; i < listaDeObjetos.Count; i++)
        {
            listaDeObjetos[i].SetActive(i < elementosActivados);
        }

    }
}