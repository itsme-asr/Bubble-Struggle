using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public void loseLife()
    {
        numberOfLives--;
        GameObject lastLife = lives[lives.Count - 1];
        lives.Remove(lastLife);
        Destroy(lastLife);

        if (lives.Count == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
