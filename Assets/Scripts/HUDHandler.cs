using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HUDHandler : MonoBehaviour
{
    public TextMeshProUGUI pointsTextBox;
    public static HUDHandler instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    
    public void UpdatePoints(int points)
    {
        pointsTextBox.text = points.ToString();
    }
}
