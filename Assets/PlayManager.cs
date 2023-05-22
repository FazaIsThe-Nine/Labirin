using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class PlayManager : MonoBehaviour
{
    [SerializeField] GameObject finishedCanvas;
    [SerializeField] TMP_Text finishedText;
    [SerializeField] CustomEvent gameOverEvent;
    [SerializeField] CustomEvent playerWinEvent;
    public int coinCount;
    [SerializeField] TMP_Text coinText;
    private void OnEnable() {
        gameOverEvent.OnInvoked.AddListener(GameOver);
        playerWinEvent.OnInvoked.AddListener(PlayerWin);
    }
    private void OnDisable() {
        gameOverEvent.OnInvoked.RemoveListener(GameOver);
        playerWinEvent.OnInvoked.RemoveListener(PlayerWin);
    }
    public void GameOver () 
    {
        finishedText.text = "Failed";
        finishedCanvas.SetActive(true);
    }
    public void PlayerWin () 
    {
        finishedText.text = "Win!\nScore:" + GetScore();
        finishedCanvas.SetActive(true);
    }
    private int GetScore () 
    {
        return coinCount;
    }
    public void Update() {
        coinText.text = "Coin: " + coinCount.ToString();
    }
}
