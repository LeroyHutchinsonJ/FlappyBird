using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployRockController : MonoBehaviour
{
    //Create a reference to the rock bullet? prefab
    public GameObject pelletPrefab;

    //This is the respawn time of the single rock
    public float respawnTime = 2.5f;

    //This is the screen bounds of the game camera
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        //This is to get the current screen boundaries
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        //This is the call to the calroutine
        StartCoroutine(PelletWave());
    }

    private void SpawnPellets()
    {
        //This creates a pellet prefab
        GameObject a = Instantiate(pelletPrefab) as GameObject;

        //This creates a random object
        Random random = new Random();

        a.transform.position = new Vector2(screenBounds.x, Random.Range(4f, -4f  ));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator PelletWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);

            SpawnPellets();
        }
    }
}
