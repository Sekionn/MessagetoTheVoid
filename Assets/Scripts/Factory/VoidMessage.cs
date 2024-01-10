using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VoidMessage : MonoBehaviour
{
    public void Initialize(string message)
    {
        gameObject.GetComponentInChildren<TMP_Text>().text = message;
    }
}
