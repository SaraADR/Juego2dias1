using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recordsSave : MonoBehaviour {


    public InputFieldControl sn;
    public ScoreTextScript ss;

    public string highscorePos;
    public string nombreH;
    public string temp;
    public string temp2;

    public void Start()
    {
        string nombre = sn.getName();
        string puntuacion = ss.GetScoreValue().ToString();
     

        int score = int.Parse(puntuacion);
        for (int i=1; i < 10; i++)
        {
            string[] scoreAndName = PlayerPrefs.GetString("highscorePos" + i).Split(' ');

            if (int.Parse(scoreAndName[5]) <= score)
            {
                temp = PlayerPrefs.GetString("highscorePos" + i);
                
                PlayerPrefs.SetString("highscorePos" + i, nombre + "     " + puntuacion);
                temp2 = PlayerPrefs.GetString("highscorePos" + i);


                if (i < 10)
                {
                    int j = i + 1;
                    score = PlayerPrefs.GetInt("highscorePos" + j);
                    PlayerPrefs.SetString("highscorePos" + j, temp);
                }
            }
        }
    }
    void OnGUI()
    {
        for (int i = 1; i <= 10; i++)
        {
            GUI.Box(new Rect(10, 25 * i, 500, 100), "Pos " + i + "       " + PlayerPrefs.GetString("highscorePos" + i));
        }
    }
}
