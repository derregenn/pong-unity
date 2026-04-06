using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int playerScore = 0;
    public int opponentScore = 0;

    public UnityEvent onScoreChange;
    public UnityEvent<string> onGameEnd;

    void Awake()
    {
        instance = this;
    }

    public void AddScore(bool playerScored)
    {
        if (playerScored)
            playerScore++;
        else
            opponentScore++;

        onScoreChange.Invoke();

        if (playerScore >= 11)
            onGameEnd.Invoke("PLAYER WIN!");
        else if (opponentScore >= 11)
            onGameEnd.Invoke("YOU LOSE!");
    }
}