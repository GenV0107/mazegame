using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private int camPos;
	public float speed =5.0f;
	public Camera Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
	{
		transform.Translate(-speed * Time.deltaTime, 0, 0);
	}
	if (Input.GetKey(KeyCode.RightArrow) )
	{
		transform.Translate(speed * Time.deltaTime, 0, 0);
	}
	if (Input.GetKey(KeyCode.UpArrow))
	{
		transform.Translate(0, speed * Time.deltaTime, 0);
	}
	if (Input.GetKey(KeyCode.DownArrow))
	{
		transform.Translate(0, -speed * Time.deltaTime, 0);
	}
    }
	private void FixedUpdate()
	{
		if (transform.position.x - camPos > 10)
		{
			camPos += 20;
			Camera.transform.position = new Vector3(camPos, 0, -10);
  		}
		if ( camPos - transform.position.x > 10)
		{
			camPos -= 20;
            Camera.transform.position = new Vector3(camPos, 0, -10);
        }
	}
}
