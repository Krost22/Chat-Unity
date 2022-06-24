using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chat : MonoBehaviour{

    public InputField Textfield;
    public Text chatb;

    public void send()
    {
        if(Textfield.text != ""){
            chatb.text += "\n" + Textfield.text;
            Textfield.text = "";
        }
    }
}
