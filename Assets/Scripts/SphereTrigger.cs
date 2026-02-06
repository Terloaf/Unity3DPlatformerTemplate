using UnityEngine;

public class SphereTrigger : MonoBehaviour
{

    public GameObject Puzzle4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Puzzle4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            Debug.Log("played");
            Puzzle4.SetActive(true);
            Destroy(other.gameObject);
            

        }
    }
}
