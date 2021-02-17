using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class URLInput : MonoBehaviour {

	public GameObject URL;
	public GameObject MainTextBox;
	public GameObject Textbox;

	public Collider coll;
	public bool TextInput;

	// Use this for initialization
	void Start () 
	{
		coll = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{ 
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (coll.Raycast(ray, out hit, 10000.0f))
			{
				TextInput = true;
				Textbox.SetActive(true);
			}
			
		}

		if (TextInput == true)
		{
			if (Input.GetKeyDown(KeyCode.Return))
			{
				URL.GetComponent<Video_Rez>().Cloud_Url = MainTextBox.GetComponent<InputField>().text;
				TextInput = false;
				Textbox.SetActive(false);
			}
		}

	}
}
