using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    [Header("UI")]
    public Text currentScore;

    
   

    // Update is called once per frame
    void Update()
    {
        currentScore.text = getrating.Instance.Score.ToString();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
