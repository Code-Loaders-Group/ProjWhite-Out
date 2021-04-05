using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosion : MonoBehaviour
{
    // to get rid of the left over explosion animation

    public void DestroyThis()
    {
        Destroy(this.gameObject);
    }
}
