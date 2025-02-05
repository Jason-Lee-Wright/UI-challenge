using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UiManager : MonoBehaviour
{
    private int ScoreCount = 999999999;

    public TextMeshProUGUI ScoreText;

    private Button Button;

    private void UpdateScore()
    {
        ScoreText.text = $"Score: {ScoreCount:N0}";
    }

    public void Increase()
    {
        EventSystem.current.SetSelectedGameObject(null);
            ScoreCount += 15;
        if (ScoreCount >= 1000000000)
        {
            ScoreCount = 999999999;
        }
            UpdateScore();
    }

    public void Decrease()
    {
        EventSystem.current.SetSelectedGameObject(null);
        if (ScoreCount > 0)
        {
            ScoreCount -= 15;
        }
        if (ScoreCount < 0)
        {
            ScoreCount = 0;
        }
        UpdateScore();
    }

    public void ResetScore()
    {
        EventSystem.current.SetSelectedGameObject(null);
        ScoreCount = 0;
        UpdateScore();
    }
}
