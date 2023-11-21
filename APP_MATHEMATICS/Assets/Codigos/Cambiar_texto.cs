using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cambiar_texto : MonoBehaviour
{
    public List<Color> colores; // Lista de colores para intercalar

    private int indiceColorActual = 0; // Índice del color actual en la lista

    // Llama a esta función para cambiar el color de los GameObjects
    public void CambiarColor()
    {
        if (colores.Count > 0)
        {
            // Encuentra todos los GameObjects con el tag "Text_found", incluso si están desactivados
            GameObject[] objetos = FindObjectsOfType<GameObject>(true);

            foreach (GameObject objeto in objetos)
            {
                if (objeto.CompareTag("Text_found"))
                {
                    // Obtiene el componente TextMeshProUGUI del objeto
                    TextMeshProUGUI texto = objeto.GetComponent<TextMeshProUGUI>();

                    if (texto != null)
                    {
                        // Cambia el color del texto a el siguiente color en la lista
                        texto.color = colores[indiceColorActual];
                    }
                }
            }

            // Incrementa el índice del color actual
            indiceColorActual++;

            // Si el índice del color actual es mayor que el número de colores en la lista, reinicia el índice
            if (indiceColorActual >= colores.Count)
            {
                indiceColorActual = 0;
            }
        }
    }
}
