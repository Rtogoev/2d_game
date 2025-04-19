using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	float randomX = Random.Range(20, 90);
        transform.position = new Vector3(randomX, 3.9F, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
