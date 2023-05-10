using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CarMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float distanceIncreased;
    [SerializeField] float steerSpeed;
    [SerializeField] public int steerLeft; 
    [SerializeField] public int steerRight;
    float steerValue;
    
    // Update is called once per frame
    void Update()
    {
        speed += distanceIncreased * Time.deltaTime;
        transform.Rotate(0f,steerValue*steerSpeed*Time.deltaTime,0f);  
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {

            SceneManager.LoadScene(0);

        }
    }
    
    //Used to change the steer value
    public void SteerChange(int value)
    {
        steerValue = value;
    } 
    /*
   public void EventTriggerLeft()
    {
        SteerChange(steerLeft);
    } public void EventTriggerRight()
    {
        SteerChange(steerRight);
    }
    public void Released()
    {
        SteerChange(0);
    }*/
}
