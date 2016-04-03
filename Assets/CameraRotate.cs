using UnityEngine;
using System.Collections;

public class CameraRotate : MonoBehaviour
{

    public GameObject what;
    public int radius;
    public float speed;

    void Update()
    {
        gameObject.transform.LookAt(what.transform);
        
        transform.position = new Vector3(0 + radius * Mathf.Cos(Time.time * speed * 2 * 3.14f), 10, 0 + radius * Mathf.Sin(Time.time * speed * 2 * 3.14f));
    }
}
