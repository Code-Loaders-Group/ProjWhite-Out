using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordSlashDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    public void DestroyThisSlash()
    {
        Destroy(this.gameObject);
    }
}
