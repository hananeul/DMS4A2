using System.Collections;
using UnityEngine;

public class FadeOutBox : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            StartCoroutine(StartFadeOut());
        }
    }

    IEnumerator StartFadeOut()
    {
        yield return new WaitForSeconds(1f); // Delay for 3 seconds before starting the fade-out

        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        Renderer renderer = GetComponent<Renderer>();
        Color startColor = renderer.material.color;
        Color targetColor = new Color(startColor.r, startColor.g, startColor.b, 0f);

        float startTime = Time.time;
        float duration = 2f; // Duration of 2 seconds for the fade-out

        while (Time.time < startTime + duration)
        {
            float t = (Time.time - startTime) / duration;
            // Interpolate from startColor with alpha 1 to targetColor with alpha 0
            renderer.material.color = new Color(startColor.r, startColor.g, startColor.b, Mathf.Lerp(1f, 0f, t));
            yield return null;
        }

        gameObject.SetActive(false);
    }
}
