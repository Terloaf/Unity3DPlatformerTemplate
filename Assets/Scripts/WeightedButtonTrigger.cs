using UnityEngine;

public class WeightedButtonTrigger : MonoBehaviour
{
    public bool _isPressed = false;
    public AudioSource _audioSource;
    public AudioClip _audioClip;

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

            gameObject.GetComponent<Renderer>().materials[1].color = new Color(0f, 1f, 0f);
            
        }
        if (collision.gameObject.CompareTag("Pickup"))
        {
            _isPressed = true;
            gameObject.GetComponent<Renderer>().materials[1].color = new Color(0f, 1f, 0f);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        _audioSource.pitch = Random.Range(0.9f, 1.1f);
        _audioSource.PlayOneShot(_audioClip);
    }

}
