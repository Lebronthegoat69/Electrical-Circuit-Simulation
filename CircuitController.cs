using UnityEngine;
using TMPro;

public class CircuitController : MonoBehaviour
{
    public bool switch1On = false;
    public bool switch2On = false;

    public SpriteRenderer bulb;
    public TextMeshProUGUI statusText;

    public Color lightOnColor = Color.yellow;
    public Color lightOffColor = Color.gray;

    void Start()
    {
        UpdateCircuit();
    }

    public void ToggleSwitch1()
    {
        switch1On = !switch1On;
        UpdateCircuit();
    }

    public void ToggleSwitch2()
    {
        switch2On = !switch2On;
        UpdateCircuit();
    }

    void UpdateCircuit()
    {
        if (switch1On && switch2On)
        {
            bulb.color = lightOnColor;
            statusText.text = "Circuit Complete";
        }
        else
        {
            bulb.color = lightOffColor;
            statusText.text = "Circuit Open";
        }
    }
}