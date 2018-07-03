using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;


public class testBuild {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	[PostProcessBuild(1)]
	public static void OnBuildOver(BuildTarget tar,string path)
	{
		Debug.Log ("Build Over,Path is :"+path);
	}
}
