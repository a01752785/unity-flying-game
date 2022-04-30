using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    // Start is called before the first frame update
    private int points = 0;
    public void SubtractPoints()
    {
        points--;
    }

    public void AddPoints()
    {
        points++;
    }

    public int GetPoints()
    {
        return points;
    }
}
