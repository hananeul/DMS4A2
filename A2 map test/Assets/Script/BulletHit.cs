using UnityEngine;

public class BulletHit : MonoBehaviour
{
    public AudioClip impactSound; 
    private AudioSource audioSource; 

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
        audioSource.clip = impactSound; 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Object hit by bullet!"); // Add debug log
            gameObject.SetActive(false);
            
            if (impactSound != null && audioSource != null)
            {
                audioSource.Play();
                Debug.Log("Impact sound played!"); // Add debug log
            }
            else
            {
                Debug.LogWarning("Audio clip or AudioSource is not set!"); // Add debug log
            }
        }
    }
}