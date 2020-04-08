using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardTextController : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = (PlayerPrefs.GetString("Score", "0"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
