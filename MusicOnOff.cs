using UnityEngine;
using UnityEngine.UI;

public class MusicOnOff : MonoBehaviour
{
    public AudioListener audio1;
    public Sprite musicOn, musicOff;
    private Image button;

    private void Awake()
    {
        button = GetComponent<Image>();
        if (PlayerPrefs.GetString("music") == "off")
        {
            button.sprite = musicOff;
            audio1.enabled = false;  
        }
    }

    public void setMusic()
    {
        audio1.enabled = !audio1.enabled;

        if (audio1.enabled)
        {
            button.sprite = musicOn;
            PlayerPrefs.SetString("music", "on");
        }
        else
        {
            button.sprite = musicOff;
            PlayerPrefs.SetString("music", "off");
        }
    }
}
