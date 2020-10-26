using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverPanel : MonoBehaviour
{
    private bool isAlive;
    public GameObject playerHolder;
    public GameObject endPanel;
    // Start is called before the first frame update
    private void Start()
    {
        endPanel.SetActive(false);
    }
    private void Update()
    {
        if (playerHolder == null)
        {
            StartCoroutine(DisplayDeathPanel());
        }
    }

    IEnumerator DisplayDeathPanel()
   {
      
            
            yield return new WaitForSeconds(3);
            endPanel.SetActive(true);

   }

    public void OnClickQuitButton()
    {
        Application.Quit();
    }
    public void OnClickReplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnClickMenuButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
