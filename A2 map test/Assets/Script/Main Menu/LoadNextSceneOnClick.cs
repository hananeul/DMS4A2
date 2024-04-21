using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadNextSceneOnClick : MonoBehaviour
{
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(LoadNextScene);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
