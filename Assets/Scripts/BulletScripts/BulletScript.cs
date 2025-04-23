using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 20F;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     name = "bullet";   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
