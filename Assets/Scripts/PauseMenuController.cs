using UnityEngine;
using System.Collections;

public class PauseMenuController : MonoBehaviour {
	GameObject pauseMenu;

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Time.timeScale = 0.00000001f;
			pauseMenu.SetActive(true);
		}
	}

	public void resume()
	{
		Time.timeScale = 1f;
		pauseMenu.SetActive(false);
	}

	public void mainMenu()
	{
		Application.LoadLevel(0);
	}
	
	public void exit()
	{
		Application.Quit();
	}
}
