using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject _button1pressed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        _button1pressed.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        _button1pressed.SetActive(false);
    }
}