using UnityEngine;

public class ButtonTriggerSystem : MonoBehaviour
{
    
     public bool _isPressed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _isPressed = true;
        }
        if (collision.gameObject.CompareTag("Pickup"))
        {
            _isPressed = true;
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        _isPressed = false;
    }
}
