using UnityEngine.SceneManagement;
using UnityEngine;

public class levelLoader : MonoBehaviour
{
    private bool mainLevel=true;
    public GameObject Player;
    void Start()
    { 
        DontDestroyOnLoad(Player);
      
     
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.N)&&mainLevel)
        {
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            mainLevel=false;
            
        }
        else if(Input.GetKeyDown(KeyCode.N)&&(!mainLevel))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
            mainLevel=true;
         }
        
    }
}
