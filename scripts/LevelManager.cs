using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int crystals;
    public int crystalGoal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (crystals == crystalGoal)
        {
            SceneManager.LoadScene("level2");
            // Application.LoadLevel("level2");
        }
    }
}
