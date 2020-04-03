using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletController : MonoBehaviour
{
    public Vector2 Velocity = new Vector2(-3, 0);
    public Rigidbody2D rgbody;

    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody2D>();
        rgbody.velocity = Velocity;    
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("StrayRockObject(Clone)") != null)
        {
            GameObject clone = GameObject.Find("StrayRockObject(Clone)");
            if (clone.transform.position.x < -15)
            {
                Destroy(clone);
            }
        }
    }
}
