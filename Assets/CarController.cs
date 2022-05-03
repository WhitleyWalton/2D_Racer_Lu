using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    //Create float variable for car x-position.
    float Xpos, Ypos;
    public float speed = 0.05f; 
    public float minX = -6.51f, maxX = 6.4f;
    public float minY = -5.81f, maxY = 6.1f;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize x-position.
        Xpos = -3.5f;
        //Initialize y-position.
        Ypos = -5.43f;

     
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.position = new Vector2(Xpos, transform.position.y);
        //Change value of x-position based on user.
        if (Input.GetKey(KeyCode.LeftArrow)){
            Xpos -= speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Xpos += speed;
        }
        //Change value of y-position based on user.
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            Ypos += speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Ypos -= speed;
        }

        //Limit boundaries for x.
        Vector3 currentPosition = transform.position;
        currentPosition.x =
            Mathf.Clamp(currentPosition.x, minX, maxX);
        transform.position = currentPosition;

        //Limit boundaries for y.
        currentPosition.y =
            Mathf.Clamp(currentPosition.y, minY, maxY);
        transform.position = currentPosition;

        //How to update and move the car based on the x-position.
        //Xpos += 0.05f;
        //How to update and rotate the car based on the z-position.
        //transform.Rotate(new Vector3(0f, 0f, Xpos));
    }
}
