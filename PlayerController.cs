using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 targetPos;
    public GameObject player;
    public float speed = 5f;
    private void Update()
    {
#if UNITY_ANDROID
        if (Input.touchCount > 0) { Touch touch = Input.GetTouch(0); 
        if (touch.phase == TouchPhase.Moved)
            {
                targetPos = Camera.main.ScreenToWorldPoint(touch.position);
                Debug.Log(targetPos);
            }
       }
#endif
#if UNITY_EDITOR
        if (Input.GetMouseButton(0))
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
#endif
       float step = speed * Time.deltaTime;
        if (targetPos.y < -3.13f)
            targetPos.y = -3.13f;
        if (targetPos.y > 1.7f)
            targetPos.y = 1.7f;


        player.transform.position = Vector3.MoveTowards(
           player.transform.position,
           new Vector3(player.transform.position.x, targetPos.y, player.transform.position.z),
    
           step);

    }

}