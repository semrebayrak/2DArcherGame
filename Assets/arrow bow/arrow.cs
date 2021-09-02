using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        trackMovement();
    }

    void trackMovement()
    {

        Vector2 direcction = rb.velocity;
        float angle = Mathf.Atan2(direcction.y, direcction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); // APLY THE ANGLE
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Score.scoreAmount += 1;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}

