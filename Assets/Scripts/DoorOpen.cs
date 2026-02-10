using UnityEditor;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;

    public GameObject door;

    [SerializeField]
    ButtonTrigger trigger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (button1.gameObject.activeInHierarchy == true && button2.gameObject.activeInHierarchy == true)
        {
            Destroy(door);
        }
    }
}
