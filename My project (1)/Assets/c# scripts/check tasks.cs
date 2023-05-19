using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checktasks : MonoBehaviour
    {
    public InputField inputField;   // ссылка на InputField

    private string collectedText;   // переменная для хранения введенного текста

    void Start()
    {
        collectedText = "";         // инициализация переменной
    }

    public void CollectInput()
    {
        collectedText = inputField.text;   // сбор введенного текста
        Debug.Log("Collected text: " + collectedText);  // вывод в консоль для проверки
    }

}
