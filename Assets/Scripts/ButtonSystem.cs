using NUnit.Framework;
using UnityEngine;

public class ButtonSystem : MonoBehaviour
{

    [SerializeField]
    ButtonTriggerSystem[] _buttons;


    public GameObject door;
    
   
  
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < _buttons.Length; i++)
        {
            if (_buttons[i]._isPressed == false)
            {
                return;
            }
        }

        door.SetActive(false);
        
    }



  
}
