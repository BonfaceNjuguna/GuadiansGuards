using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public static score instance;

    public Text scoreText;
    int scores = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = scores.ToString();
    }

    public void AddPoints()
    {
        scores = +1;
        scoreText.text = scores.ToString();
    }
}
