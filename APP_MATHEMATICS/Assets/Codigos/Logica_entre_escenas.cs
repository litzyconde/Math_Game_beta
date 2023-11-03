using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logica_entre_escenas : MonoBehaviour
{
    private void Awake()
    {
        var noDestruirEntreEscenas = FindObjectsOfType<Logica_entre_escenas>();
        if (noDestruirEntreEscenas.Length > 1)
        {

            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
