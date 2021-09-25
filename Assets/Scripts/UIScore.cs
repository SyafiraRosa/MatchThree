using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    public Text highSore;
    public Text currentSore;

    private void Update()
    {
        highSore.text = ScoreManager.Instance.HighScore.ToString();
        currentSore.text = ScoreManager.Instance.CurrentScore.ToString();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
