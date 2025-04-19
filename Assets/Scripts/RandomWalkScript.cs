using UnityEngine;

public class RandomWalkScript : MonoBehaviour
{
    public float leftXBourder = 4F;
    public float rightXBourder = 100F;
    public float steps = 0;
    public float speed = 10;
    public string direction = "wait";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         direction = "wait";
    }

    // Update is called once per frame
      void Update()
    {
	if (steps < 0) {
		steps = 0; 
		direction = "wait";
	}

       if(direction.Equals("wait")) {
		steps = 100;

    	 	float currentX = transform.position.x;
		if (currentX <= leftXBourder) {
   		       direction = "right";
   	         	steps = 1000;
		} else if (currentX >= rightXBourder) {
  	     	       direction = "left";
    			steps = 1000;
      		} else if (Random.Range(0, 100) > 50) {
    	    		direction = "right";	
   		} else {
			direction = "left";
	  	}
	} else {
             if(direction.Equals("right")) {
                transform.Translate(Vector3.right * Time.deltaTime  * speed);
             }
             if(direction.Equals("left")) {
                transform.Translate(Vector3.right * Time.deltaTime * (-speed));
             }
             steps = steps - 1;
        }
     }
}
