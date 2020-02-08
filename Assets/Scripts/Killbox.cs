using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("The " + other.gameObject.name + " GameObject Has Hit The Killbox");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("The " + other.gameObject.name + " GameObject Has Been Deleted");
        Destroy(other.gameObject);
    }
}
