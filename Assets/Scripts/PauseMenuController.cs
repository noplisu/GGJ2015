﻿using UnityEngine;
using System.Collections;

public class PauseMenuController : MonoBehaviour {
	public GameObject pauseMenu;

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Time.timeScale = 0.00000001f;
			pauseMenu.SetActive(true);
		}
	}

	public void restart()
	{
		Time.timeScale = 1f;
		Application.LoadLevel (Application.loadedLevel);
	}

	public void resume()
	{
		Time.timeScale = 1f;
		pauseMenu.SetActive(false);
	}

	public void mainMenu()
	{
		Time.timeScale = 1f;
		Application.LoadLevel(0);
	}
	
	public void exit()
	{
		Application.Quit();
	}
}
