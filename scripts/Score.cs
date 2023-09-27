using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text text;
    private Controls player;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        player = FindObjectOfType<Controls>();
    }
 
    void Update () {
        text.text = "Coin: " + player.collectedCrystals+"/500";
    }
}
