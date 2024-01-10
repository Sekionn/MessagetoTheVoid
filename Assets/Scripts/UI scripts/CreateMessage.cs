using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateMessage : MonoBehaviour
{
    MessageFactory factory;

    private void Awake()
    {
        factory = new MessageFactory();
    }

    public void CreateNewMessage(TMP_InputField input)
    {
        factory.CreateMessageObject(input.text);
    }
}
