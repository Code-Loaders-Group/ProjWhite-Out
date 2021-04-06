using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerRotation : MonoBehaviour
{
    private Camera cam;
    Rigidbody2D rb;

    // Update is called once per frame
    public void Update()
    {
        //fireball aim follows mouse position based from camera distance to cursor distance.
        Vector3 mouse = Input.mousePosition;

        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        Vector2 offset = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);

        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        gameObject.transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
