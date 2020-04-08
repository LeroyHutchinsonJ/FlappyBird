
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlaneController : MonoBehaviour
{
    //This is the rigidbody object 
    public Rigidbody2D rgbody;

    //This will be the vector direction of the jump
    public Vector2 jumpForce;
    public float timeStart;
    public int seconds;
    public Text scoreBoard;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(1);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Cast the script to the rg body object, this makes it so that the rgbody in the script controls the rg body in unity(Not neccessary if you set it in unity editor)
       // rgbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        seconds = (int)timeStart;

        scoreBoard.text = seconds.ToString();

        //When the spacebar is pressed down
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //The velocity of the rigidbody  is 0
            rgbody.velocity = Vector2.zero;

            //Add force to the rgbody
            rgbody.AddForce(jumpForce);
        }
        
        if(transform.position.y < -6 || transform.position.y > 6 )
        {
            SceneManager.LoadScene(1);
        }

        
    }
    
}
