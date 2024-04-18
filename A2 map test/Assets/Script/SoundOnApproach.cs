using UnityEngine;

public class SoundOnApproach : MonoBehaviour
{
    public string targetTag = "Box"; // Tag of the object to detect
    public AudioClip soundEffect;    // Sound effect to play
    public float detectionRadius = 5f; // Radius to detect objects

    private bool hasPlayed = false;   // To ensure the sound is played only once

    void Update()
    {
        // Check for nearby objects with the specified tag
        Collider[] colliders = Physics.OverlapSphere(transform.position, detectionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag(targetTag))
            {
                // Play sound if it hasn't been played yet
                if (!hasPlayed)
                {
                    AudioSource.PlayClipAtPoint(soundEffect, transform.position);
                    hasPlayed = true;
                }
            }
        }
    }

    // Visualize the detection radius in the editor
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}