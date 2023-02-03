using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody rb;

    public float forwardforce=1000f;
    public float sidewaysforce=500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardforce* Time.deltaTime);

        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysforce* Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysforce* Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
 