using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointSystem : MonoBehaviour
{
    public static int points = 0;
    [SerializeField] private Text pointTxt;

    private void Update()
    {
        pointTxt.text = points.ToString();
    }


}
