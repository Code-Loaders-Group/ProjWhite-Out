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
        timer += Time.deltaTime;
        if (timer >= 2)
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
