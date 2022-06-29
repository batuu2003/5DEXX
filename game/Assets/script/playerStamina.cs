using UnityEngine;

public class playerStamina : MonoBehaviour
{
    bool keepStamina=true;
    public playerMovement movement;
    public int maxStamina=100;
    public float currentStamina;
    public setStamina stamina;
    void Start()
    {
        
        currentStamina=maxStamina;
        stamina.setMaxstamina(maxStamina);
        
    }


    void Update()
    {

        if(currentStamina<1)
         {
            movement.slowDown(5f);
            keepStamina=false;

         } 
        if(currentStamina>99)
         {
            keepStamina=true;
           movement.setSpeed(10f);
         }
        if(Input.GetKeyDown(KeyCode.Space)&&currentStamina>0&&movement.IsGrounded())
        {
            takeStamina(5f);
            stamina.SetStamina(currentStamina);

        }
        if(Input.GetKey("d")&&currentStamina>0&&keepStamina)
        {
            takeStamina(0.15f);
            stamina.SetStamina(currentStamina);
        }
        if(Input.GetKey("a")&&currentStamina>0&&keepStamina)
        {
            takeStamina(0.05f);
            stamina.SetStamina(currentStamina);
        }
        
        else
     {
        if(currentStamina<100)
        {
            regenStamina(0.1f);
            stamina.SetStamina(currentStamina);
        }
     }
        
    
    }
    void regenStamina(float regen)
    {
        currentStamina+=regen;
        
    }
    void takeStamina(float damage)
    {
        currentStamina-=damage;
    }
  
}
