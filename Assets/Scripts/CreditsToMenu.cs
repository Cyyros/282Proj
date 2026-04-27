using UnityEngine;
using UnityEngine.SceneManagement; 

public class CreditsToMenu : MonoBehaviour
{
    
    public void LoadMenuScene() 
    {
        
        SceneManager.LoadScene("TitleScene");
    }
}