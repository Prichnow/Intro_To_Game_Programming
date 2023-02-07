using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int score = 0;

    public TMPro.TextMeshProUGUI uiText;

    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<TMPro.TextMeshProUGUI>(); 
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = score.ToString("#,0");
    }

    public void add100()
    {
        score += 100;
    }
}
