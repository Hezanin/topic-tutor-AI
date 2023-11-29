using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ButtonValidation : MonoBehaviour
{
    [SerializeField]
    private Quiz quiz;

    [SerializeField]
    private List<UnityEngine.UI.Button> buttons;

    [SerializeField]
    private ButtonColorUI buttonColor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool IsCorrect(string buttonText)
    {
        if (quiz.Questions.ElementAt(0).Answer.IndexOf(buttonText,
            StringComparison.OrdinalIgnoreCase) == -1)
        {
            return false;
        }

        return true;
    }

    public void Validate()
    {
        foreach (var button in buttons)
        {
            string buttonText = button.GetComponentInChildren<TextMeshProUGUI>().text;

            if (IsCorrect(buttonText))
            {
                buttonColor.SetValidColor(button);
                break;
            }
        }
    }
}
