using UnityEngine;
using UnityEngine.SceneManagement; 
public class Scene : MonoBehaviour
{
  public void LoadScene(string sceneName) {
     SceneManager.LoadScene(sceneName);   }
}
