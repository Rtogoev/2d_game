using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2LoadScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

   void OnMouseDown()
   {
        SceneManager.LoadScene(2);
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
