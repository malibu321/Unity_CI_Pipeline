// File: "GameManager.cs"

using UnityEngine;

/// <summary>
/// Manages game functionality such as quitting the game.
/// </summary>
public class GameManager : MonoBehaviour
{
	/// <summary>
	/// Checks for the escape key press and quits the game if detected.
	/// </summary>
	private void Update()
	{
		if(isEscapeKeyPressed())
		{
			QuitGame();
		}	
	}

	/// <summary>
	/// Checks if the escape key is currently pressed.
	/// </summary>
	/// <returns>True if the escape key is pressed, false otherwise.</returns>
	private bool isEscapeKeyPressed()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			return true;
		}
		return false;
	}

	/// <summary>
	/// Quits the game.
	/// </summary>
	private void QuitGame()
	{
		// Check if the game is running in the Unity Editor
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
        // If not running in the Unity Editor, quit the application
        Application.Quit();
#endif
	}
}
