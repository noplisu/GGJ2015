using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {
	public void start()
	{
		Application.LoadLevel(1);
	}

	public void exit()
	{
		Application.Quit();
	}
}
