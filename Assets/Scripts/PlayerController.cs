using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    private float offsetX = -1;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += new Vector3(offsetX, 0, 0);
            // transform.Rotate(Vector3.forward);// rotate 90 degrees on the z axis and then return back to 0
        } else if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.position -= new Vector3(offsetX, 0, 0);
            // transform.Rotate(Vector3.forward);// rotate 90 degrees on the z axis and then return back to 0
        }
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, verticalInput, horizontalInput) * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        Destroy(other.gameObject);
        Debug.Log($"Score: {score}");
    }
}
