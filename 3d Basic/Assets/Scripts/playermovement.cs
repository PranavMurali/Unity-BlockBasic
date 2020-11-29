using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce=1000f;
    public float sidewaysForce=100f;
    public float brakeForce=100f;
    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(0 , 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("s"))
        {
            rb.AddForce(0,0,-brakeForce * Time.deltaTime,ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
