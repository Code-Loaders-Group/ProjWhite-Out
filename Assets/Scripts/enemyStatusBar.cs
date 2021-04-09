using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyStatusBar : MonoBehaviour
{
    public BossScript bossScript;
    public Image fillImage;
    private Slider slider;

    // Start is called before the first frame update
    void Awake()
    {       
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }

        float fillValue = bossScript.currentHealth / bossScript.maxHealth;
        slider.value = fillValue;
    }
}
