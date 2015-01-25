using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {
	void OnTriggerEnter()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}
