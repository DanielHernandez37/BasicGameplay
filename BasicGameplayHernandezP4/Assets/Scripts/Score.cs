using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public static int lives = 3;
 

    public static void ShowScore()
    {
        Debug.LogFormat("Lives: {0}  Animals fed: {1}", score, lives);
    }
}