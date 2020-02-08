using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Background : MonoBehaviour
{
    public Transform tf;
    public Vector3 tfpos = new Vector3(10.85f,0.0f,0.0f);
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

        if (this.transform.position.x <= -10.85f)
        {
            Debug.Log("Background Has Run Out of Room");
            Reset();
        }
    }

    private void Reset()
    {
        tf.position = tfpos;
    }
}