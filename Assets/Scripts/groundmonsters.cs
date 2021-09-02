using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundmonsters : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
  
    private Vector2 screenBounds;
    private bool groundcheck = false;

    // Use this for initialization
    void Start()

    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());

    }

    IEnumerator asteroidWave()
    {

        while (true)
        {
            /* if (!groundcheck)
             {
                 yield return new WaitForSeconds(0);
                 groundcheck = true;
             }
             else*/


            //GameObject b = Instantiate(Object2) as GameObject;


            double b = Random.Range(0, 100);
            float d = -4.50f;
            if (b > 50)
            {

                GameObject a = Instantiate(Object1) as GameObject;
                a.transform.position = new Vector2(screenBounds.x * 3, d);



            }
            else
            {
                GameObject a = Instantiate(Object2) as GameObject;

                a.transform.position = new Vector2(screenBounds.x * 3, d);

            }
          

            /* else
             {
                 b.transform.position = new Vector2(screenBounds.x * 2, -4.94f);


             }*/
            yield return new WaitForSeconds((Random.Range(1.6f, 8f)));

        }
    }
}