using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("The " + other.gameObject.name + " GameObject Has Hit The Killbox");
        if (other.gameObject.name != "FLine")
        {
            Debug.Log("The " + other.gameObject.name + " GameObject Has Been Deleted");
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "Player")
        {
            SoundManageer.PlaySound("CarCrash");
            GameObject.Find("GameOver").transform.position = new Vector3(0.0f, 0.0f, -0.25f);
        }
    }
}
