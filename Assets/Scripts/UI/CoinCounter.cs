using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    private int _coin = 00;
    public int coin {
        get { return _coin; }
        set{
            _coin = value;
            coinText.text = _coin.ToString(); //Updates coin amount UI whenever player picks up a coin
            
            // Check if the player collected 40 coins and display "Game Succès"
            if (_coin >= 40) {
                Debug.Log("Game Succès!");
                Time.timeScale = 0; // Pause the game
                _coin = 00; // Reset the coin count
            }
        }
    }

    public static string goldKey = "GoldAmount";

    public TextMeshProUGUI coinText;

    void Start(){
        coin = 00;
    }

    public void SaveCoinAmount(){
        PlayerPrefs.SetInt(goldKey, coin);
        PlayerPrefs.Save();
    }

    public void ChangeCoinAmount(int amount){
        coin += amount;
        PlayerPrefs.SetInt(goldKey, coin);
        PlayerPrefs.Save();
    }
}
