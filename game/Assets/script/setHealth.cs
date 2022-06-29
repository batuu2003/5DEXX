using UnityEngine;
using UnityEngine.UI;
public class setHealth : MonoBehaviour
{
    public Slider slider;
    public void setMaxhealth(int health)
    {
        slider.maxValue=health;
        slider.value=health;
    }
    public void SetHealth(int health)
    {
        slider.value=health;
    }

}
