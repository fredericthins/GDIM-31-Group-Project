using UnityEngine;
using TMPro;
public class CoinPicker : MonoBehaviour
{

    private float coin = 0;

    public TextMeshProUGUI textCoins;  //Displays the amount of coins collected

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Coin")         //When the coin is touched the coin is removed so it doesn't recollect again.
        {
            coin++;
            textCoins.text = coin.ToString();
            Destroy(other.gameObject);
        }
    }
}

