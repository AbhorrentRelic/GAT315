using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FloatUI : MonoBehaviour
{
    public Slider slider = null;
    public TextMeshProUGUI label = null;
    public TextMeshProUGUI value = null;
    public float min;
    public float max;

    public FloatData data = null;

    private void OnValidate()
    {
        if (data != null)
        {
            name = data.name;
            label.text = name;
        }
    }

    private void Start()
    {
        slider.onValueChanged.AddListener(UpdateValue);
        slider.minValue = min;
        slider.maxValue = max;
    }

    void Update()
    {
        slider.value = data.value;
        value.text = data.value.ToString();
    }

    void UpdateValue(float value)
    {
        data.value = value;
    }
}