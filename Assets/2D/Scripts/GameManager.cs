using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] EventChannelSO playerDeathEvent;
    //[SerializeField] EventChannelSO gameStartEvent;
    [SerializeField] EventChannelSO gameWinEvent;
    //[SerializeField] EventChannelSO gameLooseEvent;

    //[SerializeField] IntEventChannelSO OnScoreEvent;



    [SerializeField] IntDataSO scoreData;

    [SerializeField] GameObject UIScreen;
    [SerializeField] GameObject WinScreen;
    [SerializeField] GameObject LooseScreen;

    [SerializeField] TMP_Text WinText;
    [SerializeField] TMP_Text LooseText;





    private void Start()
    {
        //this is no longer necessary due to the event listener component in the inspector
        //this is the code-centric way of doing it.
        playerDeathEvent.AddListener(OnPlayerDeath);
        gameWinEvent.AddListener(OnWin);
    }


    public void OnPlayerDeath()
    {
        //print("Player Dead");

        UIScreen.SetActive(false);
        LooseScreen.SetActive(true);
        LooseText.text = ("Final Score: " + scoreData.Value.ToString());
    }


    public void OnWin()
    {
        UIScreen.SetActive(false);
        WinScreen.SetActive(true);
        WinText.text = ("Final Score: " + scoreData.Value.ToString());

    }



    public void OnStartGame()
    {
        //scoreData.Value = 0;

        LooseScreen.SetActive(false);
        WinScreen.SetActive(false);
        UIScreen.SetActive(true);
    }
}
