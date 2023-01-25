using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject preFab1;
    [SerializeField] private GameObject preFab2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            splitBubble();
        }
    }


    private void splitBubble()
    {
        Instantiate(preFab1, transform.position, Quaternion.identity);
        Instantiate(preFab2, transform.position, Quaternion.identity);
    }
}