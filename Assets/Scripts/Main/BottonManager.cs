using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottonManager : MonoBehaviour
{

    public void Flappy()
    {
        Debug.Log("플래피 작동");
        SceneManager.LoadScene("Flappy");
    }
    public void Shooting()
    {
        Debug.Log("슈팅 작동");
        SceneManager.LoadScene("Shooting");
    }
}
