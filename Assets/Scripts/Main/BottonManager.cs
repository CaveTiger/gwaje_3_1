using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottonManager : MonoBehaviour
{

    public void Flappy()
    {
        Debug.Log("�÷��� �۵�");
        SceneManager.LoadScene("Flappy");
    }
    public void Shooting()
    {
        Debug.Log("���� �۵�");
        SceneManager.LoadScene("Shooting");
    }
}
