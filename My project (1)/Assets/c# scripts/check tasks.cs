using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checktasks : MonoBehaviour
{
    public static string myName;
    private Text myText;
    void Start ()
    {
        myText = GetComponent <Text> ();
    }
    void Update ()
    {
        myName = myText.text.ToString ();
    }
}
