using NUnit.Framework;
using UnityEngine;

public class ButtonSystem : MonoBehaviour
{
    public [] _buttons;
    public int _buttonsToUse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Buttons(_buttonsToUse);
    }

    public void Buttons(int amount)
    {
        _buttons.GetValue(amount);
    }
}
