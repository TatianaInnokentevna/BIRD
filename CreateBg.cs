using UnityEngine;

public class CreateBg : MonoBehaviour
{
    public GameObject now_bg, bg_inst;
    private GameObject new_bg;

    void Update()
    {
        if (StartGame.isStart)
        {
            if (now_bg.transform.position.x <= -1f && new_bg == null)
            CreateNewBg();
            else if (new_bg != null && new_bg.transform.position.x <= -1f)
            CreateNewBg();
        }
    }

    void CreateNewBg()
    {
        if (now_bg.transform.position.x < -10f)
        {
            Destroy(now_bg);
            now_bg = new_bg;
        }
        new_bg = Instantiate(bg_inst, new Vector2(11.5f, -1.27f), Quaternion.identity) as GameObject;
    }
}
