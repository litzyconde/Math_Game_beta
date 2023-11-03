using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Variar_valor : MonoBehaviour
{
    public TMP_Text textObject; // referencia al objeto de texto TMProç
    public int currentValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textObject.text = "x = " + currentValue.ToString();
    }
    public void valorsiguiente(int orden)
    {
        if(orden == 0)
        {
            currentValue++;
        }
        else if(orden == 1)
        {
            currentValue--;
        }
        else if(orden == 2)
        {
            currentValue = currentValue*-1;
        }
        else if(orden == 3)
        {
            currentValue = 0;
        }
    }
}
