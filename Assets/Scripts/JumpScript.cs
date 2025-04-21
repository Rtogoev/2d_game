using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public float bottomYBourder =  3.9F;
    public float topYBourder = 8F;
    public float speed = 10F;
    public string state = "none";
    public AudioClip jumpSound;
    private AudioSource playerAudio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = "none";
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
	float currentY = transform.position.y;

	if(state.Equals("up")) {
		if (currentY < topYBourder) {
			transform.Translate(Vector3.up * Time.deltaTime  * speed);
		} else {
			state = "down";
		}
	}

	if(state.Equals("down")) {
		if (currentY > bottomYBourder) {
			transform.Translate(Vector3.up * Time.deltaTime  * -speed);
		} else {
			transform.position =  new Vector3(transform.position.x, 3.9F, transform.position.z);
			state = "none";
		}
	}

	if(state.Equals("none")) {
       		if (Input.GetKeyDown(KeyCode.W)) {
			if(state.Equals("none")) {
				playerAudio.PlayOneShot(jumpSound);
				state = "up";
			}
		
		}
	}
     }
}