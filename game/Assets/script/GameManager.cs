using UnityEngine;

public class GameManager : MonoBehaviour
{
    public playerStamina staminaPlayer;
    public Menu menu;
    public playerMovement player;
    bool pauseEnded=true;
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Escape)&&(!pauseEnded))
        {
            menu.closePauseMenu();
            player.enabled=true;
            pauseEnded=true;
            staminaPlayer.enabled=true;
        }
        else if(Input.GetKeyDown(KeyCode.Escape)&&pauseEnded)
        {
            menu.PauseMenu(); 
            player.enabled=false;
            pauseEnded=false;
            staminaPlayer.enabled=false;
        }
       
    }
}
