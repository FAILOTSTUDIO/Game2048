using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField]private int Level;
    private Scene ThisLevel; //// Служит для Рестарта левела после проигрыша!

    private void Start()
    {
        if(Level < 0)
        {
            Level = 1;
        }
        ThisLevel = SceneManager.GetActiveScene();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(ThisLevel.name,LoadSceneMode.Single);
    }
}
