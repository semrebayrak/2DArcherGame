using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    private Vector2 screenBounds;
    public float LaunchForce;
    public GameObject Arrow;
    float a = 0;
    public double arrowwait = 0.50;
    int arrowcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        
        

        if (Input.GetMouseButtonDown(0) && !ESC.GameIspaused )
        {
            Shoot(0);
            if (Score.scoreAmount > 5)
            {
                Shoot(1f);
            }
            if (Score.scoreAmount > 15)
            {
                Shoot(2f);
            }
            a = Time.time;
        }
      
    }

  
    void Shoot(float arrowcount)
    {
        Vector3 location = transform.position;
        location.y += arrowcount/3;
        GameObject ArrowIns = Instantiate(Arrow, location, transform.rotation);

        ArrowIns.GetComponent<Rigidbody2D>().AddForce(transform.right * LaunchForce);
    }
}
