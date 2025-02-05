using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UiManager : MonoBehaviour
{
    private int ScoreCount;

    public TextMeshProUGUI ScoreText;

    private Button Button;

    private void UpdateText()
    {
        ScoreText.text = $"Score: {ScoreCount:N0}";
    }

    public void Increase()
    {
        EventSystem.current.SetSelectedGameObject(null);
        ScoreCount += 15;
        UpdateText();
    }

    public void Decrease()
    {
        EventSystem.current.SetSelectedGameObject(null);
        ScoreCount -= 15;
        UpdateText();
    }

    public void Reset()
    {
        EventSystem.current.SetSelectedGameObject(null);
        ScoreCount = 0;
        UpdateText();
    }
}
