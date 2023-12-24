using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextLogic : MonoBehaviour
{
    public PlayerHealth pH;
    public TextMeshProUGUI textComponent;

    void Update()
    {
        textComponent.text = pH.score.ToString("0");
    }
}
