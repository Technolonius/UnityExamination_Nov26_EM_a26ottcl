using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SimpleUIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hpText;
    
    private int score;
    private int hp;

    void Start()
    {
        AddScore(0);
    }
    
    public void AddScore(int addScore)
    {
        score += addScore;
        
        scoreText.text = $"Coins: {score}";
    }

    public void ModifyHP(int addHp)
    {
        hp += addHp;
        hpText.text = $"HP: {hp}";
    }
}
