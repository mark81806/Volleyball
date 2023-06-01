using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnCtl : MonoBehaviour
{
    const string ImagePath = "Sprites/";
    const string animationPath = "Prefabs/Events/";
    public Text number;
    int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void closeWindow() {
        Destroy(GameObject.FindWithTag("window"));
    }
    public void click() {
        num += 1;
        number.text = num.ToString();
        //ima.image.sprite = Load("Buttons", "Buttons_0");
        if (num >= 10){
            Event.self.Award();
            Destroy(GameObject.FindWithTag("eventanimation"));
        }
    }
    // Update is called once per frame
    Sprite Load(string imageName, string spriteName)
    {
        Sprite[] all = Resources.LoadAll<Sprite>(imageName);
        foreach (var s in all)
        {
            if (s.name == spriteName)
            {
                return s;
            }
        }
        return null;
    }
}
