
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private short score = 0;    

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("knife"))
        {
            score++;
            scoreText.text = "Счет: " + score.ToString();

            if(PlayerPrefs.GetInt("score") < score)
            PlayerPrefs.SetInt("score", score);
        }
    }
}
