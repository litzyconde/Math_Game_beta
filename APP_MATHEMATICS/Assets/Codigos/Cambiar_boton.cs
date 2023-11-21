using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cambiar_boton : MonoBehaviour
{
    public List<Sprite> imagenes; // Lista de imágenes para intercalar

    private int indiceImagenActual = 0; // Índice de la imagen actual en la lista

    // Llama a esta función para cambiar la imagen de los GameObjects
    public void CambiarImagen()
    {
        if (imagenes.Count > 0)
        {
            // Encuentra todos los GameObjects con el tag "Button_found", incluso si están desactivados
            GameObject[] objetos = FindObjectsOfType<GameObject>(true);

            foreach (GameObject objeto in objetos)
            {
                if (objeto.CompareTag("Button_found"))
                {
                    // Obtiene el componente Button del objeto
                    Button boton = objeto.GetComponent<Button>();
                    // Obtiene el componente Image del objeto
                    Image imagen = objeto.GetComponent<Image>();

                    if (boton != null)
                    {
                        // Cambia la imagen del botón a la siguiente imagen en la lista
                        boton.image.sprite = imagenes[indiceImagenActual];
                    }
                    else if (imagen != null)
                    {
                        // Cambia la imagen del objeto a la siguiente imagen en la lista
                        imagen.sprite = imagenes[indiceImagenActual];
                    }
                }
            }

            // Incrementa el índice de la imagen actual
            indiceImagenActual++;

            // Si el índice de la imagen actual es mayor que el número de imágenes en la lista, reinicia el índice
            if (indiceImagenActual >= imagenes.Count)
            {
                indiceImagenActual = 0;
            }
        }
    }
}
