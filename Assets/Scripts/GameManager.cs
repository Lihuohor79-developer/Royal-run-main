using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] UIManager uiManager;
    [SerializeField] float scoreFactor;
    [SerializeField] AudioSource audioSource; // Coin Sound Source
    [SerializeField] AudioClip coinSound;     // Coin Sound Clip
    [SerializeField] AudioSource musicSource; // Background Music Source
    
    float score = 0;
    int coin = 0;
    int life = 3;

    private void Start()
    {
        // Pause game at start for Main Menu
        Time.timeScale = 0;

        // Initialize UI
        if (uiManager != null)
        {
            uiManager.UpdateScore((int)score);
            uiManager.UpdateCoins(coin);
            uiManager.UpdateLives(life);
        }
        
        // Get AudioSource if not assigned
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();

        // Start Music
        if (musicSource != null)
        {
            musicSource.loop = true;
            musicSource.Play();
        }
    }

    private void Update()
    {
        if (life > 0)
        {
            score += Time.deltaTime * scoreFactor;
            if (uiManager != null)
                uiManager.UpdateScore((int)score);
        }
    }

    public void ChangeCoin(int amount)
    {
        if (life <= 0) return; // Don't collect coins if dead
        coin += amount;
        
        // Play Sound
        if (audioSource != null && coinSound != null)
        {
            audioSource.PlayOneShot(coinSound);
        }

        if (uiManager != null)
            uiManager.UpdateCoins(coin);
    }

    public void ChangeLife(int amount)
    {
        if (life <= 0) return; // Already dead

        life += amount;
        Debug.Log($"[GameManager] Life changed by {amount}. Current Life: {life}");
        
        if (life <= 0)
        {
            life = 0;
            Debug.Log("[GameManager] Game Over Triggered! Stopping Time.");
            
            // Stop the game
            Time.timeScale = 0;
            
            // Stop Music
            if (musicSource != null)
            {
                musicSource.Stop();
            }
            
            if (uiManager != null)
            {
                uiManager.UpdateLives(life);
                uiManager.ShowGameOver((int)score);
            }
        }
        else
        {
            if (uiManager != null)
                uiManager.UpdateLives(life);
        }
    }
}
