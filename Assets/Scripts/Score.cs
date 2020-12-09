using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int pinCount;
    public Text text;         
    void Start()
    {
        pinCount = 0;   //Bunu burada belirttik çünkü sahneyi restart ettiğimizde static variables resetlenmiyor.Skoru üstüne ekleyerek devam etmesin diye start'ın içine yazdık.         
    }                                
    void Update()
    {
        text.text = pinCount.ToString();        
    }
}
