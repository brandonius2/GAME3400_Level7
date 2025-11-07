using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class TextController : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public float refRate = 6.0f;
    public float countdown = 0.0f;

    public List<string> textCollection = new List<string>() { "WWWWWWW",
        "w rizz",
        "LLLLl",
        "67 67 67",
        "wtf is that outside", 
        "Wumphrey", 
        "ts so scary", 
        "holy guacamole!", 
        "AHHHHHH", 
        "what's the pattern here?", 
        "Oh my god bruh", 
        "Lumphrey", 
        "y u so scared", 
        "is there smth outside?", 
        "suck my balls", 
        "L rizzzzzzzzz", 
        "holy shmock", "I love this pattern", "aomngus sus", "is dat the bite of 87", "yo yo yo 420 67"};
    public List<string> nameCollection = new List<string>() { "zSpidxr", 
        "daRillionare", 
        "C_Barney",
        "m980011334", 
        "FF-Yan", 
        "Caminolf", 
        "kLabrewqu", 
        "fortniteMan", 
        "fantastic4sk1n",
        "Logang_Pauler", 
        "MagaDude69420", 
        "LittleDiaper",
        "IceSpicePoopy", 
        "T_Swizzle", 
        "P4trick_Mahomes", "C Shwizzle", "BSchling", "DaPrezAoun", "t", "ChrisAlexanderPattern", "https:patternlanguage", "Pibble"};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        countdown = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        countdown += 1.0f * Time.deltaTime;
        if (countdown >= refRate)
        {
            text5.text = text4.text;
            text4.text = text3.text;
            text3.text = text2.text;
            text2.text = text1.text;
            text1.text = getRand(nameCollection) + ": " + getRand(textCollection);
            countdown = 0.0f;
        }
        
    }

    public string getRand(List<string> a)
    {
        int index = Random.Range(0, a.Count);
        return a[index];
    }
}
