using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class titlescreen : MonoBehaviour
{
    public string newGameScene;
    public void LoadGame()
    {
        SceneManager.LoadScene(newGameScene);
    }

	public void Quit()
	{
		Application.Quit();
	}
}

