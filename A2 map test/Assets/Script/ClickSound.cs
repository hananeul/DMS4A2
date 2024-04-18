using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioClip clickSound;

    private void Update()
    {
        // Check for left mouse button click
        if (Input.GetMouseButtonDown(0))
        {
            // Play the click sound
            AudioSource.PlayClipAtPoint(clickSound, transform.position);
        }
    }
}