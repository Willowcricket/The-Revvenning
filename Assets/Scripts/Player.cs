using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform tf;
    public float movementSpeed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position += tf.up * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tf.position -= tf.up * movementSpeed * Time.deltaTime;
        }
    }

    /*public void OnCollisionEnter2D(Collision2D otherObject)
    {
        Debug.Log("The Player Has Collided With " + otherObject.gameObject.name);
        Destroy(this.gameObject);
    }*/
}
