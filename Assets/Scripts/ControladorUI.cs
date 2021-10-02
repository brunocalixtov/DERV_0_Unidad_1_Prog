using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{

    public TextMeshProUGUI texto;

    public void saludar() {
        texto.text = "Hola Amigo :D! Gracias";
    }
}
