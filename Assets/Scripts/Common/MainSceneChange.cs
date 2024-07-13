using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneChange : MonoBehaviour
{
  [SerializeField] private string rightScene;
  [SerializeField] private string leftScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchRightScene() {
      SceneManager.LoadScene(rightScene);
    }

    public void SwitchLeftScene() {
      SceneManager.LoadScene(leftScene);
    }
}
