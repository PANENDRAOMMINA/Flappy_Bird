using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]public TMP_Text Score_text;
    [SerializeField] private TMP_Text Personal_Best;
    private int Score=0;
   
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("High_Score"))
        {
            Personal_Best.text = PlayerPrefs.GetInt("High_Score").ToString();
        }
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Reload_Scene()
    {
        if(Score>PlayerPrefs.GetInt("High_Score"))
        {
            PlayerPrefs.SetInt("High_Score", Score);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Increase_Score()
    {
        Score++;
        Score_text.text = Score.ToString();
    }
}
