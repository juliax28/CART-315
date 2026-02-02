using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializedField] private PlayerController playerController;
    public Canvas GameOverCanvas;
    public TMP_Text TimerText;

    private void Awake(){
        if (playerController != null)
        {
            playerController.PlayerDied += WhenPLayerDies;
        }
        if(GameOverCanvas.gameObject.activeSelf)
        {
            GameOverCanvas.gameObject.SetActive(false);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    void WhenPLayerDies()
    {
        GameOVerCanvas.gameObject.SetActive(true);
        TimerText.text = "You Lasted" + Math.Round(Time.timeSinceLevelLoad, 2);
        if (playerController != null)
        {
            playerController.PlayerDied -= WhenPLayerDies;
        }
    }
    // Update is called once per frame
    public void RetryClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
