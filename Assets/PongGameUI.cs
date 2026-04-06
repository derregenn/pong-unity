using TMPro;
using UnityEngine;

public class PongGameUI : MonoBehaviour
{
    public TextMeshProUGUI playerText;
    public TextMeshProUGUI opponentText;
    public TextMeshProUGUI statusText;

    void Start()
    {
        GameManager.instance.onScoreChange.AddListener(UpdateScore);
        GameManager.instance.onGameEnd.AddListener(EndGame);
    }

    void UpdateScore()
    {
        playerText.text = GameManager.instance.playerScore.ToString();
        opponentText.text = GameManager.instance.opponentScore.ToString();
    }

    void EndGame(string msg)
    {
        statusText.text = msg;
    }
}