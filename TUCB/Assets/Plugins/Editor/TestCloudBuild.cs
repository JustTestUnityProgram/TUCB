using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCloudBuild
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	static void OnPreBuild()
	{
		Debug.Log ("OnPreBuild");
	}

	static void OnPostBuild()
	{
		Debug.Log ("OnPostBuild");
	}
}
