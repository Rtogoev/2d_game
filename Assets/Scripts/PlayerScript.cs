using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float horizontalInput = 0F;
    public float leftXBourder = 4F;
    public float rightXBourder = 100F;
    public float speed = 10F;
    public GameObject bullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
	transform.position = new Vector3(9F, 3.9F, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bullet, transform.position, bullet.transform.rotation);
        }
        float currentX = transform.position.x;
	if (currentX <= leftXBourder) {
       		horizontalInput =  Input.GetAxis("Horizontal");
                if (horizontalInput > 0) {
     			transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
                }
	} else {
		if(currentX >= rightXBourder) {
			horizontalInput =  Input.GetAxis("Horizontal");
               		 if (horizontalInput < 0) {
     				transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
               		 }
		} else {
                         horizontalInput =  Input.GetAxis("Horizontal");
               		 transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
               		
                }
         }
     }
}