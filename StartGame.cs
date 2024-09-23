using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject logoText;
    public static bool isStart;
    public float hideSpeed = 5f;
    public GameObject scoreText;

    private void Update()
    {
        if (isStart && logoText != null)
            logoText.transform.Translate(Vector2.up * hideSpeed * Time.deltaTime);
    }
    public void startGame()
    {
        if (isStart) { return; }

        isStart = true;
        logoText.GetComponent<Animator>().enabled=false;
        Destroy( logoText, 1.5f );
        GetComponent<Animation>().Play("HidePlayButton");
        scoreText.SetActive(true);
    }

    
    
}
