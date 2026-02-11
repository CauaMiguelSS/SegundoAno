using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneConttroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SceneManager.SetActiveScene(gameObject.scene);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Firel"))
        {
            if (SceneManager.sceneCount == 1)
                return;

            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        }
    }
}
