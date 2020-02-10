using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
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
        tf.position -= tf.right * movementSpeed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Player Won");
            SoundManageer.PlaySound("YouWon");
            Destroy(other.gameObject);
            GameObject.Find("GameWon").transform.position = new Vector3(0.0f, 0.0f, -0.25f);
        }
    }
}
