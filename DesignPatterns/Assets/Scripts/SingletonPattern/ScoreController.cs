using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    private int _score;

    public static ScoreController Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void AddScore(int value)
    {
        _score += value;
        _scoreText.text = "Score = " + _score;
    }
}
