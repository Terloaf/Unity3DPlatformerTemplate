using Unity.VisualScripting;
using UnityEngine;

public class SuperHeavyWeightedButton : MonoBehaviour
{
    public bool _isPressed;
    public Material _material;
    public int _mass;
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
        if (collision.rigidbody.mass >= _mass)
        {
            _isPressed = true;
            gameObject.GetComponent<Renderer>().materials[1].color = new Color(0f, 1f, 0f);
        }
    }


    private void OnCollisionExit(Collision collision)
    {

        if (collision.rigidbody.mass >= 1.5)
        {
            _isPressed = false;
            gameObject.GetComponent<Renderer>().materials[1].color = _material.color;
        }
        
    }
}
