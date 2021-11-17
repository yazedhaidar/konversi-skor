using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getrating : MonoBehaviour
{
    private int score;
   

    #region Singleton

    private static getrating _instance = null;

    public static getrating Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<getrating>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: getrating not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    private float time;
    public int Score { get { return score; } }
    public GameObject[] stars;
    public KeyCode enter = KeyCode.Return;


    // Start is called before the first frame update
    void Start()
    {
        
      
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 1f)  
        {
            scoreincrement();
            time = 0f;
        }
        

        
        if (Input.GetKey(enter))
        {

            Time.timeScale = 0f;
            if (score < 10)
            {
                stars[0].SetActive(true);
            }
            else if (score > 10 && score < 20) 
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
            }
            else if (score > 20)
            {
                stars[0].SetActive(true);
                stars[1].SetActive(true);
                stars[2].SetActive(true);
            }
            return;
        }
    }


    public void  scoreincrement()
    {
        score += 1;
    }
}
