using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameStartButtonAction()
    {
        SceneManager.LoadScene("CutScene_OP");
    }
    public void exit()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
