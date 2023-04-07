using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitMovement : MonoBehaviour
{
    private Rigidbody fruitRb;
    private float speed = 10;
    private float yBoundary = -5;
    // Start is called before the first frame update
    void Start()
    {
        fruitRb = GetComponent<Rigidbody>();
        speed += Random.Range(-1.0f, 3.0f);
        fruitRb.AddForce(Vector3.up * speed * fruitRb.mass, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yBoundary)
        {
            Destroy(gameObject);
        }
    }
}
