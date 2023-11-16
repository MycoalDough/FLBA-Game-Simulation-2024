using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LoginSystem : MonoBehaviour
{

    public string nameOfPlayer;
    public string career;
    public TMP_InputField field;
    public GameObject toDiable;

    public void changeCareer(string t)
    {
        career = t;
    }

    public void startGame()
    {
        if(field.text.Length > 2 && career != "")
        {
            field.text = nameOfPlayer;
            toDiable.SetActive(false);
        }
    }
}
