
using UnityEngine;

public class MoveKnife : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        if (StartGame.isStart)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= -5f)
                Destroy(gameObject);
        }
    }



}
