using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Working : MonoBehaviour
{

    public TextMeshProUGUI dayCalendar;
    public GameObject calanderDay;

    public TextMeshProUGUI dailyOptionName1;
    public TextMeshProUGUI dailyOptionName2;
    public TextMeshProUGUI dailyOptionDesc1;
    public TextMeshProUGUI dailyOptionDesc2;

    public TextMeshProUGUI tutorial;

    public TextMeshProUGUI moneyT;
    public TextMeshProUGUI employeeT;
    public TextMeshProUGUI knowledgeT;
    public TextMeshProUGUI friendT;

    public int money;
    public int employee;
    public int knowledge;
    public int friend;

    public void tutorialSet()
    {
        tutorial.text = "Hello, ";
    }
}
