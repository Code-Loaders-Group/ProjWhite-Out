using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private float timer = 0;
    public GameObject restartText;
    // Start is called before the first frame update
    void Update()
    {
        timer = timer + 1;
        if (timer >= 360)
        {
            restartText.SetActive(true);
            if (Input.GetKey(KeyCode.R))
            {
                timer = 0;
                SceneManager.LoadScene(0);              
            }
        }             
    }
}
