using UnityEngine;

public class BoxTriggerable : MonoBehaviour, ITriggerable
{

    private void Start()
    {
        gameObject.SetActive(false);
    }

    void ITriggerable.DoButtonLogic()
    {
        gameObject.SetActive(true);
    }
}
