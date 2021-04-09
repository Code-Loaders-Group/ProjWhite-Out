using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSlomanSpawner2 : MonoBehaviour
{
    public GameObject Sloman, SlomanSpawn;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("EnemySpawn", 2.0f, 4.0f);
    }

    // Update is called once per frame
    void Update()
    {


    }
    void EnemySpawn()
    {
        GameObject.Instantiate(Sloman, SlomanSpawn.transform.position, SlomanSpawn.transform.rotation);
    }
}
