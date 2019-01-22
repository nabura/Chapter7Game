using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalArea : MonoBehaviour {
    public static bool goal;
    public AudioSource bgm;
    public AudioSource goalBgm;

	// Use this for initialization
	void Start () {
	    goal = false;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            goal = true;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            bgm.Stop();
            //other.gameObject.GetComponent<AudioSource>().Stop();
            goalBgm.Play();
        }
    }
}
