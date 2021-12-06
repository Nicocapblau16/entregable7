using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private string screenMessage;

    public TextMeshProUGUI messageUI;

    
    void Start()
    {
        //mensaje inicial
        screenMessage = "Pulsa una flecha";
        messageUI.text = screenMessage;
    }

    // Update is called once per frame
    void Update()
    {
        //llamamos la función
        ShowMessage(screenMessage, KeyCode.RightArrow);
        ShowMessage(screenMessage, KeyCode.LeftArrow);
        ShowMessage(screenMessage, KeyCode.UpArrow);
        ShowMessage(screenMessage, KeyCode.DownArrow);
        ShowMessage(screenMessage, KeyCode.Space);
      

        
    }

    public void ShowMessage(string message, KeyCode key)
    {
        //función
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            message = "Derecha";
            messageUI.text = message;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            
            message = "Izquierda";
            messageUI.text = message;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            message = "Arriba";
            messageUI.text = message;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            

            message = "Abajo";
            messageUI.text = message;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            message = "Aaaaaaaaaaaaaaaaaa";
            messageUI.text = message;

        }
    }

    //gracias por la ayuda en discord ^^
}