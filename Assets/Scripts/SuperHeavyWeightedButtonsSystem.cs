using System.Collections.Generic;
using UnityEngine;

public class SuperHeavyWeightedButtonsSystem : MonoBehaviour
{

    [SerializeField]
    SuperHeavyWeightedButton[] _superWeightedButtons;




    [SerializeField]
    List<GameObject> triggerableGameObjects;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _superWeightedButtons.Length; i++)
        {
            if (_superWeightedButtons[i]._isPressed == false)
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
