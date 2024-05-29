using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void onStartBtnClicked()
    {
        SceneManager.LoadScene(1);
    }
}
