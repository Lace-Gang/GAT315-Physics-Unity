using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [SerializeField] Slider healthBar;
    [SerializeField] TMP_Text ScoreText;

    [SerializeField] FloatDataSO playerHealth;
    [SerializeField] IntDataSO playerScore;


    // Start is called once before the first excution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = playerHealth;
        ScoreText.text = ("Score: " + playerScore.Value.ToString());
    }
}
