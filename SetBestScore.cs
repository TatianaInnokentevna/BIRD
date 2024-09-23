using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SetBestScore : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<TextMeshProUGUI>().text = "Рекорд: " + PlayerPrefs.GetInt("score").ToString();
    }
}
