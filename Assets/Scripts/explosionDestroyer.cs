using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionDestroyer : MonoBehaviour
{
    public void DestroyThis()
    {
        Destroy(this.gameObject);
    }
}
