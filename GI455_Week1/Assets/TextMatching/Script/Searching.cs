using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Searching : MonoBehaviour
{
    public string[] nameapp;
    public Text apptext;
    public Button search;
    public InputField nametext;
    public Text checktext;
    
    // Start is called before the first frame update

    void Start()
    {
        AddName();
        search.onClick.AddListener(SearchingName);
    } 

    public void SearchingName()
    {
       if(nametext.text == nameapp[0] || nametext.text == nameapp[1] || nametext.text == nameapp[2] || nametext.text == nameapp[3] || nametext.text == nameapp[4])
            checktext.text = nametext.text + " IS <color=#00ff00ff>FOUND</color>";
       else
            checktext.text = nametext.text + " IS <color=#ff0000ff>NOT FOUND</color>";
    }
    public void AddName()
    {
        apptext.text = "" + nameapp[0] + "\n" + nameapp[1] + "\n" + nameapp[2] + "\n" + nameapp[3] + "\n" + nameapp[4];
    }
}
