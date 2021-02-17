using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour {

	// Use this for initialization

	public GameObject VideoPlayer;
	public Collider coll;
	public bool isplaying = false;

	void Start () 
	{
		coll = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		isplaying = VideoPlayer.GetComponent<Video_Rez>().PlayVid;

		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (coll.Raycast(ray, out hit, 10000.0f))
			{
				if (isplaying == false)
				{
					VideoPlayer.GetComponent<Video_Rez>().PlayVid = true;
				}
				else if(isplaying == true)
				{
					VideoPlayer.GetComponent<Video_Rez>().PlayVid = false;
				}
			}

		}
	}
}
