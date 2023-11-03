using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Estado_bateria : MonoBehaviour
{
    public Variar_valor variable;
    public GameObject volver;
    public TMP_Text textObject; // referencia al objeto de texto TMPro
    public
    // Update is called once per frame
    void Update()
    {
        if(variable.currentValue <=-2)
        {
            textObject.text = "La bateria se quedo sin energia";
            volver.SetActive(false);
        }
        else if(variable.currentValue >=4)
        {
            textObject.text = "La bateria esta sobrecargada";
            volver.SetActive(false);
        }
        else if(variable.currentValue ==3)
        {
            textObject.text = "La bateria esta cargada exitosamente";
            volver.SetActive(true);
        }
        else 
        {
            textObject.text = "La bateria esta en proceso de carga";
            volver.SetActive(false);
        }

    }
}
