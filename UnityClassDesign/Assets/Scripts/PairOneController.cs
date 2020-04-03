using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PairOneController : MonoBehaviour
{
    //This is the velocity of the pillars
    public Vector2 Velocity = new Vector2(-3,0);
    public Rigidbody2D rgBody;

    // Start is called before the first frame update
    void Start()
    {
        rgBody = GetComponent<Rigidbody2D>();
        rgBody.velocity = Velocity;
        
    }

    // Update is called once per frame
    void Update()
    {
  
    }

}
