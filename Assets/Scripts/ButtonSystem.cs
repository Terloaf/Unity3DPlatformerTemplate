using JetBrains.Annotations;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class ButtonSystem : MonoBehaviour
{

    [SerializeField]
    ButtonTriggerSystem[] _buttons;



    [SerializeField]
    List<GameObject> triggerableGameObjects;
 
   
    
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

        
        Debug.Log("all buttons pressed");
        for (int j = 0; j < triggerableGameObjects.Count; j++)
        {
            
            ITriggerable triggerable = triggerableGameObjects[j].GetComponent<ITriggerable>();
            if (triggerable == null) return;
            triggerable.DoButtonLogic();
        }
        
        
        
        
    }
  


}
