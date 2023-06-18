using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingToStartWindow : MonoBehaviour
{
   
    void Start()
    {
        Bird.GetInstance().OnStartedPlaying += WaitingToStartWinDow_OnStartedPlaying;
    }
    private void WaitingToStartWinDow_OnStartedPlaying(object sender, System.EventArgs e)
    {
        Hide();
    }
    private void Hide()
    {
        gameObject.SetActive(false);
    }
    void Update()
    {
        gameObject.SetActive(true);
    }
}
