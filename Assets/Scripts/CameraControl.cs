using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private float m_speed;
    public float dragSpeed = 0.32f;
    private Vector3 dragOrigin;
    private int screenHeight;
    private int screenWidth;


    // Start is called before the first frame update
    void Start()
    {
      m_speed = 3.0f;
      screenHeight = Screen.height;
      screenWidth = Screen.width;

      Debug.Log("Screen H: " + screenHeight);
      Debug.Log("Screen W: " + screenWidth);
      
    }

    // Update is called once per frame
    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");


        if(Input.GetMouseButtonDown(0))
            Debug.Log("Mouse Position: " + Input.mousePosition.x + " - " + + Input.mousePosition.y);


        if(moveH != 0.0f || moveV != 0.0f)
            transform.Translate(new Vector3(moveH*Time.deltaTime*m_speed , moveV*Time.deltaTime*m_speed, 0.0f));        

        //Moves camer when mouse is near edge of screen
        //if(Input.mousePosition.x < 1500 && Input.mousePosition.x > -500 && Input.mousePosition.y < 1000 && Input.mousePosition.y > 300 )
        //{
        if (Input.mousePosition.x > screenWidth - 1)
            transform.Translate( new Vector3 (m_speed*Time.deltaTime, 0.0f, 0.0f) );
        else
            if (Input.mousePosition.x < 1)
                transform.Translate( new Vector3 (-m_speed*Time.deltaTime, 0.0f, 0.0f) );
        
        if(Input.mousePosition.y > screenHeight - 1)
            transform.Translate( new Vector3 (0.0f, m_speed*Time.deltaTime, 0.0f) );
        else
            if(Input.mousePosition.y < 1)
                transform.Translate( new Vector3 (0.0f, -m_speed*Time.deltaTime, 0.0f) );
        //}
        
        //Moves camera according to mouse movement when button is pressed
        /*if (Input.GetMouseButtonDown(1)) 
        {
            dragOrigin = Input.mousePosition;
            return;
        }
 
        if (!Input.GetMouseButton(1)) return;
 
        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed, 0);
 
        transform.Translate(move, Space.World); */
    }
}
