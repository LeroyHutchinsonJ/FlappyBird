using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployRockPair : MonoBehaviour
{
    //This is the reference to the RockPairPrefab
    public GameObject rockPairPrefab;

    //This is the respawn time of the rockpair
    public float respawnTime = 10.0f;

    //This is to get the screen dimensions
    private Vector2 screenBounds;

    //Start is called before the first frame update
    void Start()
    {
        //This get the boundaries of the current screen
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
       
        //This is to call the calroutine
        StartCoroutine(RockWave());
    }

    
    
    //This is the function that is going to create the rocks
    private void SpawnRocks()
    {
        //This spawns a game object
        GameObject a = Instantiate(rockPairPrefab) as GameObject;

        Random random = new Random();

        //This sets the location of the rocks
        a.transform.position = new Vector2(screenBounds.x, Random.Range(-2f, -9f));      
    }
    void Update()
    {
        if(GameObject.Find("RockPair(Clone)") != null)
        {
            GameObject clone = GameObject.Find("RockPair(Clone)");
            if (clone.transform.position.x < -15)
            {
                Destroy(clone);
            }
        }
        
    }
    IEnumerator RockWave()
    {
        //This allows us to wait a couple seconds before spawning rock pairs
        while(true)
        {
           
            yield return new WaitForSeconds(respawnTime);
           
            SpawnRocks();

          
           
        }
        
    }
  
}
