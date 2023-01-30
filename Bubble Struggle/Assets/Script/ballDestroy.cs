using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballDestroy : MonoBehaviour
{
    [SerializeField] private AudioSource smashBubble;
    public void dead()
    {
        playSmash();
        Destroy(gameObject);
    }

    public void playSmash()
    {
        if (smashBubble != null)
        {
            smashBubble.Play();
        }
    }
}
