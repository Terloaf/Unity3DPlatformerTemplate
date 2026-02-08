using System.Collections;
using UnityEngine;

public class SphereTrigger : MonoBehaviour
{

    public GameObject _puzzle4;
    public GameObject _cutscene;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _puzzle4.SetActive(false);
        _cutscene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            _cutscene.gameObject.SetActive(true);

            _puzzle4.SetActive(true);
          
        }


    }


}
