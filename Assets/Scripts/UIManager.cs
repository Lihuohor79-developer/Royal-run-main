using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("HUD")]
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text coinText;
    [SerializeField] TMP_Text lifeText;
    [SerializeField] GameObject hudPanel;
    [SerializeField] Image damageOverlay; // New field for the Red image

    // ... (Game Over and Main Menu headers remain same)

    public void UpdateLives(int lives)
    {
        if (lifeText != null)
        {
            // Check if we lost a life (simple check: if text was not empty and new lives < old lives, but here we just flash on any update that isn't init)
            // Better: Trigger flash if lives < 3 (assuming max is 3) or just call a separate function.
            // For simplicity, let's just flash every time this is called, assuming it's called on damage.
            
            lifeText.text = lives.ToString();
            // Juice: Pop effect
             StartCoroutine(AnimateScale(lifeText.transform, 1.5f, 0.2f));
             
             // Trigger Red Flash
             if (damageOverlay != null && lives < 3 && lives > 0) // Don't flash on init (3) or death (0 - game over covers it)
             {
                 StartCoroutine(DamageFlash());
             }
        }
    }

    private System.Collections.IEnumerator DamageFlash()
    {
        damageOverlay.gameObject.SetActive(true);
        Color c = damageOverlay.color;
        c.a = 0.5f; // Start semi-transparent
        damageOverlay.color = c;

        float duration = 0.5f;
        float timer = 0;

        while (timer < duration)
        {
            c.a = Mathf.Lerp(0.5f, 0f, timer / duration);
            damageOverlay.color = c;
            timer += Time.deltaTime;
            yield return null;
        }

        damageOverlay.gameObject.SetActive(false);
    }
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TMP_Text finalScoreText;

    [Header("Main Menu")]
    [SerializeField] GameObject mainMenuPanel;

    private void Start()
    {
        // Show Main Menu at start
        ShowMainMenu();
    }

    public void UpdateScore(int score)
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
            // Juice: Pop effect
            StartCoroutine(AnimateScale(scoreText.transform, 1.2f, 0.1f));
        }
    }

    public void UpdateCoins(int coins)
    {
        if (coinText != null)
        {
            coinText.text = coins.ToString();
            // Juice: Bounce effect
            StartCoroutine(AnimateScale(coinText.transform, 1.3f, 0.15f));
        }
    }



    // Simple "Juice" Coroutine for popping/scaling elements
    private System.Collections.IEnumerator AnimateScale(Transform target, float scaleSize, float duration)
    {
        Vector3 originalScale = Vector3.one; 
        Vector3 targetScale = Vector3.one * scaleSize;

        float timer = 0;
        while (timer < duration)
        {
            target.localScale = Vector3.Lerp(originalScale, targetScale, timer / duration);
            timer += Time.deltaTime;
            yield return null;
        }

        timer = 0;
        while (timer < duration)
        {
            target.localScale = Vector3.Lerp(targetScale, originalScale, timer / duration);
            timer += Time.deltaTime;
            yield return null;
        }
        target.localScale = originalScale;
    }

    public void ShowGameOver(int finalScore)
    {
        if (hudPanel != null) hudPanel.SetActive(false);
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
            if (finalScoreText != null)
                finalScoreText.text = "Score: " + finalScore.ToString();
        }
    }

    public void HideGameOver()
    {
        if (gameOverPanel != null) gameOverPanel.SetActive(false);
    }

    public void ShowHUD()
    {
        if (hudPanel != null) hudPanel.SetActive(true);
        if (mainMenuPanel != null) mainMenuPanel.SetActive(false);
        if (gameOverPanel != null) gameOverPanel.SetActive(false);
    }

    public void ShowMainMenu()
    {
        if (mainMenuPanel != null) mainMenuPanel.SetActive(true);
        if (hudPanel != null) hudPanel.SetActive(false);
        if (gameOverPanel != null) gameOverPanel.SetActive(false);
    }

    // Button Callbacks
    public void OnRestartClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnPlayClicked()
    {
        ShowHUD();
        Time.timeScale = 1; 
    }
}
