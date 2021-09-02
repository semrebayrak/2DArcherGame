using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{

    public float healthamount = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthamount <= 0)
        {
            Destroy(this.gameObject);
            Score.scoreAmount += 1;
        }
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "arrow")
        {

            healthamount -= 1;
            Destroy(other.gameObject);

        
            
        }
    }
}
