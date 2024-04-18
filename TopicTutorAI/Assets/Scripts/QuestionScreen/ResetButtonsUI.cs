using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButtonsUI : MonoBehaviour
{
    [SerializeField]
    private ImageColorUI ImageColor;

    [SerializeField]
    private List<Button> buttons;

    public void ResetButtonsUIColors()
    {
        foreach (Button button in buttons)
        {
            ImageColor.SetDefaultColor(button.GetComponent<Image>());
        }
    }
}
