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

    /*void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("The " + other.gameObject.name + " GameObject Has Hit The Killbox");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("The " + other.gameObject.name + " GameObject Has Left The Killbox");
        Debug.Log("The " + other.gameObject.name + " GameObject Has Been Deleted");
        Destroy(other.gameObject);
    }*/

}
