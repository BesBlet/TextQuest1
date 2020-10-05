using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InforButton : MonoBehaviour
{
    public void ButtonInform()
    {
        SceneManager.LoadScene(2);
    } 
}
