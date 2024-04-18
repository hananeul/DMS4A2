using UnityEngine;

public class HitSound : MonoBehaviour
{
    public AudioClip disappearanceSound; // Assign the disappearance sound clip in the Inspector
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // If AudioSource is not attached, add it
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void Disappear()
    {
        // Check if a disappearance sound clip is assigned
        if (disappearanceSound != null)
        {
            // Play the disappearance sound
            audioSource.PlayOneShot(disappearanceSound);
        }

        // Perform the disappearing logic here
        gameObject.SetActive(false); // For example, deactivate the GameObject
    }
}