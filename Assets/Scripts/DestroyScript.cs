using UnityEngine;

public class DestroyScipt : MonoBehaviour
{
public float leftXBourder = 4F;
    public float rightXBourder = 100F;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
	float currentX = transform.position.x;
	if (currentX <= leftXBourder) {
		Destroy(gameObject);
        }
	if(currentX >= rightXBourder) {
		Destroy(gameObject);
	}
        
    }
}
