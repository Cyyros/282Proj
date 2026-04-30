using UnityEngine;
using UnityEngine.SceneManagement;

public class DungeonTP : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
