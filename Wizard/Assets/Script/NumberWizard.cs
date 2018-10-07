using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] private int max;

    [SerializeField] private int min;

    [SerializeField] private TextMeshProUGUI guessText;
    private int guess;

    // Use this for initialization
    private void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        NextGuess();
        guessText.text = guess.ToString();
    }

    public void OnPressLower()
    {
        max = guess + 1;
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess - 1;
        NextGuess();
    }

    private void NextGuess()
    {
        guess = (Random.Range(min, guess) + Random.Range(guess, max + 1)) / 2;
        guessText.text = guess.ToString();
    }
}