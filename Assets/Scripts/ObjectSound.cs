using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ObjectSound : MonoBehaviour
{
    AudioSource audioSource;
    bool hasPlayed = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Debug to see what we hit and when
        // Debug.Log($"[ObjectSound] Hit: {collision.gameObject.name} at {Time.time}");

        if (!hasPlayed && !collision.gameObject.CompareTag("Player"))
        {
            // Use PlayOneShot for better responsiveness with multiple sounds
            if (audioSource.clip != null)
            {
                audioSource.PlayOneShot(audioSource.clip);
                hasPlayed = true;
            }
        }
    }
}
