using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class Add : MonoBehaviour
{
    public TMP_Text numbertext;
    public int cont;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update() {
        numbertext.text = cont.ToString();
    }
    // Update is called once per frame
    public void adding()
    {
        cont++;
    }
}
