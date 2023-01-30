using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    [SerializeField] private int numberOfLives = 5;
    [SerializeField] private GameObject heartPrefab;

    private List<GameObject> lives;
    public void Start()
    {
        lives = new List<GameObject>();
        for (int i = 0; i < numberOfLives; i++)
        {
            GameObject heartInstance = Instantiate(heartPrefab, transform);
            lives.Add(heartInstance);
        }

    }

}
