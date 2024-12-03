using UnityEngine;

public class pipeMovment : MonoBehaviour
{
    public float movmentSpeed = 10;
    public float deadZone = -100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movmentSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone )
        {
            Destroy(gameObject);
        }
    }
}
