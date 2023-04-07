using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CatBox : MonoBehaviour
{
    public string savename;
    
    public TMP_InputField field;
    public Slider slider;
    public TMP_Text value;

    // Start is called before the first frame update
    void Start()
    {
        field.text = PlayerPrefs.GetString(savename, "");
        slider.value = PlayerPrefs.GetInt(savename, 10);
    }

    // Update is called once per frame
    public void SetField()
    {
        PlayerPrefs.SetString(savename, field.text);
    }

    public void SetSlider()
    {
        PlayerPrefs.SetInt(savename, (int)slider.value);
    }

    private void Update()
    {
        var temp = (float)(slider.value / 4);
        value.text = temp.ToString();
    }
}
