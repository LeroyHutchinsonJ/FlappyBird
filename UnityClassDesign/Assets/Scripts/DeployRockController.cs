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
        GameObject b = Instantiate(pelletPrefab) as GameObject;
        GameObject c = Instantiate(pelletPrefab) as GameObject;

        GameObject d = Instantiate(pelletPrefab) as GameObject;
        GameObject e = Instantiate(pelletPrefab) as GameObject;
        GameObject f = Instantiate(pelletPrefab) as GameObject;

        a.transform.position = new Vector2(Random.Range(screenBounds.x, screenBounds.x + 10), Random.Range(4f, -4f));
        b.transform.position = new Vector2(Random.Range(screenBounds.x, screenBounds.x + 10), Random.Range(4f, -4f));
        c.transform.position = new Vector2(Random.Range(screenBounds.x, screenBounds.x + 10), Random.Range(4f, -4f));

        d.transform.position = new Vector2(Random.Range(screenBounds.x, screenBounds.x + 10), Random.Range(4f, -4f));
        e.transform.position = new Vector2(Random.Range(screenBounds.x, screenBounds.x + 10), Random.Range(4f, -4f));
        f.transform.position = new Vector2(Random.Range(screenBounds.x, screenBounds.x + 10), Random.Range(4f, -4f));
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
