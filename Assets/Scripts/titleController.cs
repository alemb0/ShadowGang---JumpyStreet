using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titleController : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("TerrainScene");
    }

    public void StartInstruction()
    {
        SceneManager.LoadScene("InstructionsScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
