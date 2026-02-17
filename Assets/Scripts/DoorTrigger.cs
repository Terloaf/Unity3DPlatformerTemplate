using JetBrains.Annotations;
using UnityEngine;

public class DoorTrigger : MonoBehaviour, ITriggerable
{

    void ITriggerable.DoButtonLogic()
    {


        gameObject.SetActive(false);
        Debug.Log("door Open");
    }
}
