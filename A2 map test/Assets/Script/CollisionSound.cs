using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public AudioClip collisionSound; // Assign your audio clip in the Unity editor
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // Check if AudioSource is not attached, add it dynamically
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = collisionSound;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the "Bullet" tag
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Play the collision sound
            audioSource.Play();
        }
    }
}