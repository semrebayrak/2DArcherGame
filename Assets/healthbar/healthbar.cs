using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthbar : MonoBehaviour
{
    public GameObject Object;
    private Transform bar;
    public static bool flag = false;
    public static float sizeNormalized = 1f;
    private void Awake()
    {


        sizeNormalized = 1f;

    }

    private void Start()
    {
        Object.transform.position = new Vector2(-6.9f, 4.17f);
        bar = transform.Find("Bar");
      
      

    }
    public void Update()
    {
       

       
        bar.localScale =  new Vector3(sizeNormalized, 0.161f, 0f);
    }

   
}
