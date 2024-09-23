using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void restartGame()
    {
        //Application.LoadLevel("SampleScene");
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

}
