using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Some_Data//data doesnt need a mono behavior, because it will be JUST data
{
    public static int score = 0;
    public int player_level = 1;

    //static method
    public static void AddScore(int v)
    {
        Some_Data.score += v;
    }
}
