using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D birdRigitBody;
    public float junpPower = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        birdRigitBody.linearVelocity = Vector2.up * 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            birdRigitBody.linearVelocity = Vector2.up * junpPower;
        }
    }
}
