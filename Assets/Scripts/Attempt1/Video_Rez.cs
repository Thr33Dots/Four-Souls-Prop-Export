using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Rez : MonoBehaviour {

	public GameObject MainVideo;
	public VideoPlayer VidPlay;
	public bool PlayVid;
	public string Cloud_Url;

	private bool Lock = false;
	public Vector3 Vidsize;
	public Vector3 Vidnewsize;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (PlayVid == true)
		{
			VidPlay.Play();
			if (Lock == false)
			{
				Lock = true;
				VidPlay.url = Cloud_Url;
				/*Vidsize.x = VidPlay.clip.width;
				Vidsize.y = VidPlay.clip.height;
				Vidnewsize = new Vector3((Vidsize.x / Vidsize.y) * 10, 0.1f, (Vidsize.y / Vidsize.y) * 10);
				MainVideo.transform.localScale = Vidnewsize;*/
			}
		}
		else if (PlayVid == false)
		{
			VidPlay.Stop();
			if (Lock == true)
			{
				Lock = false;
			}
		}
	}
}
