using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public static float time;

	// Use this for initialization
	void Start () {
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(GoalArea.goal == false)
        {//ゴールしていないとき
            time += Time.deltaTime;     //時間経過
        }

        //時間の表示
        int t = Mathf.FloorToInt(time);
        Text uiText = GetComponent<Text>();
        uiText.text = "Time:" + t.ToString();
	}
}
