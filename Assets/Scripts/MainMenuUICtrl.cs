﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUICtrl : MonoBehaviour {

	public void LoadScene(string SceneName) {
		SceneManager.LoadScene(SceneName);
	}
}
