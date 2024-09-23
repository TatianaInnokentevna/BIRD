using System.Collections;
using UnityEngine;


public class CreateKnife : MonoBehaviour
{
    public GameObject knife;
    public float waitTime = 1f;
    private bool isSpawn;
    private Coroutine spawn;

    private void Update()
    {


        if (StartGame.isStart && !isSpawn)
        {
            spawn = StartCoroutine(spawnKnifes());
            isSpawn = true;
        }

        IEnumerator spawnKnifes()
        {
            while (true)
            {
                if (StartGame.isStart)
                {
                    Instantiate(knife, new Vector2(5.38f, Random.Range(-3.3f, 2f)), Quaternion.identity);
                }

                else StopCoroutine(spawn);
                yield return new WaitForSeconds(waitTime);
                
            }
        }
    }
}
