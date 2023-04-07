using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Avarage : MonoBehaviour
{
    public static Avarage me;

    public Toggle edit;

    public TMP_Text average;
    // Start is called before the first frame update
    void Start()
    {
        me = this;
        int a = PlayerPrefs.GetInt("toggle", 1);
        if (a == 1)
        {
            edit.isOn = true;
        }
        else
        {
            edit.isOn = false;
        }
        SetToggle();
    }

    // Update is called once per frame
    public void SetToggle()
    {
        SetEditMode(edit.isOn);
    }

    public void ResetAverage()
    {
        float temp = 0;
        for (int i = 0; i < sliders.Length; i++)
        {
            temp += sliders[i].value;
        }
        temp = temp / 4;
        temp = temp / 12;
        temp = temp * 100;
        Debug.Log(temp);
        int a = (int)temp;
        temp = (float)a / 100;

        average.text = temp.ToString();
    }

    public CanvasGroup[] group;

    public Slider[] sliders;

    void SetEditMode(bool input) 
    {
        for (int i = 0; i < group.Length; i++)
        {
            group[i].interactable = input;
            group[i].blocksRaycasts = input;
        }
    }
}
